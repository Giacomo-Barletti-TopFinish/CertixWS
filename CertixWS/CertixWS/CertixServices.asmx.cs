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
    [WebService(Namespace = "http://tempuri.org/")]
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
            bool IsTest = Properties.Settings.Default.IsTest;

            try
            {
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("********** ERRORE IN UPLOADCODE");
                sb.AppendLine(string.Format(" IdLine: {0}  ", IdLine));
                sb.AppendLine(string.Format("Code: {0}  ", Code));
                ScriviEccezioneInLog(ex, sb.ToString());
            }

            return "UploadCode eseguito";
        }

        [WebMethod(MessageName = "AcquisisceMisure", Description = "Acquisisce le misure")]
        public string UploadMeasures(int IdMeasure, string JSON)
        {
            ScriviMessaggioInLog("*************  UploadMeasures Richiamato");
            bool IsTest = Properties.Settings.Default.IsTest;

            try
            {

            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("********** ERRORE IN UPLOADMEASURES");
                sb.AppendLine(string.Format(" IdMeasure: {0}  ", IdMeasure));
                sb.AppendLine(string.Format("JSON: {0}  ", JSON));
                ScriviEccezioneInLog(ex, sb.ToString());
            }
            return "UploadMeasures eseguito";
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
    }
}
