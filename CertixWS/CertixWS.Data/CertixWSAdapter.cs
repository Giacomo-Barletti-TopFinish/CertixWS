using CertixWS.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertixWS.Data
{
    public class CertixWSAdapter : CertixWSAdapterBase
    {
        public CertixWSAdapter(System.Data.IDbConnection connection, IDbTransaction transaction) :
            base(connection, transaction)
        { }


        public void FillUSR_PRD_MOVFASI(CertixDS ds, List<string> IDPRDMOVFASE)
        {
            string inCOndition = ConvertToStringForInCondition(IDPRDMOVFASE);

            string select = @"SELECT DISTINCT * FROM USR_PRD_MOVFASI WHERE IDPRDMOVFASE in ( {0} )";
            select = string.Format(select, inCOndition);

            using (DbDataAdapter da = BuildDataAdapter(select))
            {
                da.Fill(ds.USR_PRD_MOVFASI);
            }
        }

        public void FillUSR_PRD_FASI(CertixDS ds, List<string> IDPRDFASE)
        {
            string inCOndition = ConvertToStringForInCondition(IDPRDFASE);

            string select = @"SELECT DISTINCT * FROM USR_PRD_FASI WHERE IDPRDFASE in ( {0} )";
            select = string.Format(select, inCOndition);

            using (DbDataAdapter da = BuildDataAdapter(select))
            {
                da.Fill(ds.USR_PRD_FASI);
            }
        }

        public void FillUSR_PRD_MOVFASIByBarcode(CertixDS ds, string Barcode)
        {
            string select = @"SELECT * FROM USR_PRD_MOVFASI WHERE BARCODE = $P{Barcode}";

            ParamSet ps = new ParamSet();
            ps.AddParam("Barcode", DbType.String, Barcode);

            using (DbDataAdapter da = BuildDataAdapter(select, ps))
            {
                da.Fill(ds.USR_PRD_MOVFASI);
            }
        }

        public void FillMAGAZZ(CertixDS ds, List<string> IDMAGAZZ)
        {
            string inCOndition = ConvertToStringForInCondition(IDMAGAZZ);

            string select = @"SELECT DISTINCT * FROM GRUPPO.MAGAZZ WHERE IDMAGAZZ in ( {0} )";
            select = string.Format(select, inCOndition);

            using (DbDataAdapter da = BuildDataAdapter(select))
            {
                da.Fill(ds.MAGAZZ);
            }
        }

        public void FillAP_GALVANICA_SPESSORI(CertixDS ds, string IDMAGAZZ, string IDMAGAZZ_WIP)
        {

            string select = @"select sp.* from ap_galvanica_spessori sp
                                inner join ap_galvanica_modello mo on mo.brand = sp.brand and mo.finitura = sp.finitura
                                where mo.idmagazz = $P{IDMAGAZZ} and mo.idmagazz_wip = $P{IDMAGAZZ_WIP}";

            ParamSet ps = new ParamSet();
            ps.AddParam("IDMAGAZZ", DbType.String, IDMAGAZZ);
            ps.AddParam("IDMAGAZZ_WIP", DbType.String, IDMAGAZZ_WIP);

            using (DbDataAdapter da = BuildDataAdapter(select, ps))
            {
                da.Fill(ds.AP_GALVANICA_SPESSORI);
            }
        }

        public void FillAP_GALVANICA_SPESSORI(string Brand, string Finitura, CertixDS ds)
        {

            string select = @"select sp.* from ap_galvanica_spessori sp
                                where sp.brand = $P{BRAND} 
                            and sp.finitura = $P{FINITURA}";

            ParamSet ps = new ParamSet();
            ps.AddParam("BRAND", DbType.String, Brand);
            ps.AddParam("FINITURA", DbType.String, Finitura);

            using (DbDataAdapter da = BuildDataAdapter(select, ps))
            {
                da.Fill(ds.AP_GALVANICA_SPESSORI);
            }
        }
        public void FillAP_GALVANICA_MODELLO(CertixDS ds, string IDMAGAZZ, string IDMAGAZZ_WIP)
        {

            string select = @"select mo.* from ap_galvanica_modello mo 
                            where mo.idmagazz = $P{IDMAGAZZ} and mo.idmagazz_wip = $P{IDMAGAZZ_WIP}";

            ParamSet ps = new ParamSet();
            ps.AddParam("IDMAGAZZ", DbType.String, IDMAGAZZ);
            ps.AddParam("IDMAGAZZ_WIP", DbType.String, IDMAGAZZ_WIP);

            using (DbDataAdapter da = BuildDataAdapter(select, ps))
            {
                da.Fill(ds.AP_GALVANICA_MODELLO);
            }
        }

        public void UpdateTable(string tablename, CertixDS ds)
        {
            string query = string.Format(CultureInfo.InvariantCulture, "SELECT * FROM {0}", tablename);

            using (DbDataAdapter a = BuildDataAdapter(query))
            {
                try
                {
                    a.ContinueUpdateOnError = false;
                    DataTable dt = ds.Tables[tablename];
                    DbCommandBuilder cmd = BuildCommandBuilder(a);
                    a.UpdateCommand = cmd.GetUpdateCommand();
                    a.DeleteCommand = cmd.GetDeleteCommand();
                    a.InsertCommand = cmd.GetInsertCommand();
                    a.Update(dt);
                }
                catch (DBConcurrencyException ex)
                {

                }
                catch
                {
                    throw;
                }
            }
        }

        public void FillAP_CERTIX(CertixDS ds, Decimal IDMISURECERTIX)
        {

            string select = @"select * from AP_CERTIX where IDMISURECERTIX = $P{IDMISURECERTIX}";

            ParamSet ps = new ParamSet();
            ps.AddParam("IDMISURECERTIX", DbType.Decimal, IDMISURECERTIX);

            using (DbDataAdapter da = BuildDataAdapter(select, ps))
            {
                da.Fill(ds.AP_CERTIX);
            }
        }

        public void FillAP_CERTIX_DETTAGLIO(CertixDS ds, Decimal IDMISURECERTIX)
        {

            string select = @"select * from AP_CERTIX_DETTAGLIO where IDMISURECERTIX = $P{IDMISURECERTIX}";

            ParamSet ps = new ParamSet();
            ps.AddParam("IDMISURECERTIX", DbType.Decimal, IDMISURECERTIX);

            using (DbDataAdapter da = BuildDataAdapter(select, ps))
            {
                da.Fill(ds.AP_CERTIX_DETTAGLIO);
            }
        }
    }
}
