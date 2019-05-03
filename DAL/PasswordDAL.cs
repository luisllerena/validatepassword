using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DAL
{
    public class PasswordDAL
    {
        public RespuestaAPI GetPasswordConditions(string valor, string conexion)
        {
            var response = new RespuestaAPI();

            try
            {
                using (OracleConnection conn = new OracleConnection(conexion))
                {
                    using (OracleCommand cmd = conn.CreateCommand())
                    {
                        try
                        {
                            conn.Open();
                            cmd.CommandText = "PKG_OBSERVACIONES.USP_CONSULTA_OBS_AREA";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            var PI_Idsolicitud = new OracleParameter("PI_Idsolicitud", OracleDbType.Int32, 2136, ParameterDirection.Input);
                            var PI_AREA = new OracleParameter("PI_AREA", OracleDbType.Int32, 9, ParameterDirection.Input);
                            var PO_RESULSET = new OracleParameter("PO_RESULSET", OracleDbType.RefCursor, ParameterDirection.Output);
                            var po_error_Code = new OracleParameter("PO_ERROR_CODE", OracleDbType.Varchar2, 10, ParameterDirection.Output);
                            var po_error_Message = new OracleParameter("PO_ERROR_MESSAGE", OracleDbType.Varchar2, 100, ParameterDirection.Output);

                            cmd.Parameters.Add(PI_Idsolicitud);
                            cmd.Parameters.Add(PI_AREA);
                            cmd.Parameters.Add(PO_RESULSET);
                            cmd.Parameters.Add(po_error_Code);
                            cmd.Parameters.Add(po_error_Message);

                            using (var dr = cmd.ExecuteReader())
                            {
                                if (dr.HasRows)
                                {
                                    while (dr.HasRows)
                                    {

                                    }
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            response.Message = ex.Message;
                        }
                    }
                }
            } catch(Exception ex)
            {

            }
          
            return response;
        }
    }
}
