using CertixWS.BLL;
using CertixWS.Common;
using CertixWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;

namespace CertixWS
{
    /// <summary>
    /// Summary description for CertixServices
    /// </summary>
    [WebService(Namespace = "http://CertixWS.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CertixServices : System.Web.Services.WebService
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
       (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [WebMethod(MessageName = "MetodoTest", Description = "Metodo per test connessione")]
        public string TestMethod()
        {
            ScriviMessaggioInLog("*************  MetodoTest Richiamato");
            return "Test Method Eseguito";
        }

        [WebMethod(MessageName = "AcquisisceCodice", Description = "Acquisizione codice a barre")]
        public string UploadCode(int IdLine, string Code)
        {
            ScriviMessaggioInLog("*************  UploadCode Richiamato");

            try
            {
                CertixBLL bll = new CertixBLL();
                int IdMeasure = bll.CreateIdMeasureFromCodeAndIdLine(IdLine, Code, Properties.Settings.Default.IsTest);
                List<string> Measures = bll.CreateMaterialsListFromCode(Code, Properties.Settings.Default.IsTest);

                UploadCodeResponse response = new UploadCodeResponse();
                response.Status = Status.OK;
                response.Error = string.Empty;
                response.IdMeasure = IdMeasure;
                response.Materials = Measures;

                return JSonSerializer.Serialize<UploadCodeResponse>(response);
            }
            catch (ArgumentException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("********** ERRORE IN UPLOADCODE");
                ScriviErroreGestitoInLog(ex, sb.ToString());
                return CreaUploadCodeResponsePerErrore(ex.Message);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("********** ERRORE IN UPLOADCODE");
                sb.AppendLine(string.Format(" IdLine: {0}  ", IdLine));
                sb.AppendLine(string.Format("Code: {0}  ", Code));
                ScriviEccezioneInLog(ex, sb.ToString());
                return CreaUploadCodeResponsePerErrore("Errore non recuperabile.");
            }

        }

        [WebMethod(MessageName = "AcquisisceMisure", Description = "Acquisisce le misure")]
        public string UploadMeasures(int IdMeasure, string JSON)
        {
            ScriviMessaggioInLog("*************  UploadMeasures Richiamato");
            bool IsTest = Properties.Settings.Default.IsTest;

            try
            {
                List<UploadMeasuresElementRequest> UploadMeasuresElements = JSonSerializer.Deserialize<List<UploadMeasuresElementRequest>>(JSON);

                CertixBLL bll = new CertixBLL();
                bll.RegistraMisure(IdMeasure, UploadMeasuresElements, Properties.Settings.Default.IsTest);

            }
            catch (ArgumentException ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("********** ERRORE IN UPLOADCODE");
                ScriviErroreGestitoInLog(ex, sb.ToString());
                return CreaUploadMeasuresResponse(Status.ERRORE, ex.Message);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("********** ERRORE IN UPLOADCODE");
                sb.AppendLine(string.Format(" IdMeasure: {0}  ", IdMeasure));
                sb.AppendLine(string.Format("JSON: {0}  ", JSON));
                ScriviEccezioneInLog(ex, sb.ToString());
                return CreaUploadMeasuresResponse(Status.ERRORE, "Errore non recuperabile.");
            }
            return CreaUploadMeasuresResponse(Status.OK, string.Empty);
        }

        private void ScriviMessaggioInLog(string messaggio)
        {
            log.Info(messaggio);
        }
        private void ScriviEccezioneInLog(Exception ex, string messaggio)
        {
            log.Error(messaggio);
            while (ex != null)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
                ex = ex.InnerException;
            }
        }

        private void ScriviErroreGestitoInLog(Exception ex, string messaggio)
        {
            log.Error(messaggio);
            while (ex != null)
            {
                log.Warn(ex.Message);
                log.Warn(ex.StackTrace);
                ex = ex.InnerException;
            }
        }
        private string CreaUploadCodeResponsePerErrore(string messaggioErrore)
        {
            UploadCodeResponse response = new UploadCodeResponse();
            response.Status = Status.ERRORE;
            response.Error = messaggioErrore;
            response.IdMeasure = -1;
            response.Materials = new List<string>();

            return JSonSerializer.Serialize<UploadCodeResponse>(response);
        }

        private string CreaUploadMeasuresResponse(string Status, string messaggioErrore)
        {
            UploadMeasuresResponse response = new UploadMeasuresResponse();
            response.Status = Status;
            response.Error = messaggioErrore;

            return JSonSerializer.Serialize<UploadMeasuresResponse>(response);
        }
    }
}
