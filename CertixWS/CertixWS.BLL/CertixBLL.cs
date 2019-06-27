using CertixWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertixWS.BLL
{
    public class CertixBLL
    {
        public int CreateIdMeasureFromCodeAndIdLine(int IdLine, string Code, bool IsTest)
        {
            if (IsTest)
            {
                if (IdLine < 0)
                {
                    string m = string.Format("Codice IdLine: {0} non valido", IdLine);
                    throw new ArgumentException(m);
                }

                if (Code == "12345678912345") return DateTime.Now.Minute;

                string messaggio = string.Format("Codice Code: {0} non valido", Code);
                throw new ArgumentException(messaggio);
            }

            return -1;
        }

        public List<string> CreateMaterialsListFromCode(string Code, bool IsTest)
        {
            if (IsTest)
            {

                if (Code == "12345678912345") return new List<string>(new string[] { "Au", "Ni", "Pd" });

                string messaggio = string.Format("Codice Code: {0} non valido", Code);
                throw new ArgumentException(messaggio);
            }

            return new List<string>();
        }

        public void RegistraMisure(int IdMeasure, List<UploadMeasuresElementRequest> UploadMeasuresElements, bool IsTest)
        {
            if (IsTest)
            {
                if (IdMeasure < 0)
                {
                    string messaggio = string.Format("IdMeasure: {0} non valido", IdMeasure);
                    throw new ArgumentException(messaggio);
                }
                return;
            }

            if (!VerificaIdMeasure(IdMeasure))
            {
                string messaggio = string.Format("IdMeasure: {0} non censito a sistema", IdMeasure);
                throw new ArgumentException(messaggio);
            }

            VerificaMuasures(IdMeasure, UploadMeasuresElements);

            SalvaMuasures(IdMeasure, UploadMeasuresElements);
        }

        private bool VerificaIdMeasure(int IdMeasure)
        {
            // verifica che il codice esista nel sistema
            return true;
        }

        private void VerificaMuasures(int IdMeasure, List<UploadMeasuresElementRequest> UploadMeasuresElements)
        {
            bool esito = true;
            StringBuilder sb = new StringBuilder();
            foreach (UploadMeasuresElementRequest m in UploadMeasuresElements)
            {
                if (m.Material.Length > 10)
                {
                    esito = false;
                    sb.AppendLine(string.Format("Materiale: {0} lunghezza etichetta non valida", m.Material));
                }
            }
            // verifica che il codice materiale sia coerente con il codice a barre associato a IdMeasure

            if (!esito)
            {
                throw new ArgumentException(sb.ToString());
            }
        }

        private void SalvaMuasures(int IdMeasure, List<UploadMeasuresElementRequest> UploadMeasuresElements)
        {

        }
    }
}
