using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data.OleDb;

namespace HiberoExtintores
{
    class cldBancoDeDados
    {

        public static OracleConnection AbreBanco()
        {
            string StringConexao = "Data Source=(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
            + "User Id=hibero;Password=123456;";

            try
            {
                OracleConnection conn = new OracleConnection(StringConexao);
                conn.Open();
                return conn;
            }

            catch (Exception ex)
            {
                //trow new Exception("O Banco Não foi aberto, favor rever. Segue")
                //return (Convert.ToString(ex.Message));

                throw ex;

            }
        }



        public void FechaBanco(OracleConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); }
            }

            catch (Exception e)
            { throw e; }

        }

        public DataSet RetornaDataSet(string strQuery)
        {
            OracleConnection conn;
            conn = AbreBanco();

            try
            {
                DataSet ds = new DataSet();
                OracleCommand cmdComando = new OracleCommand(strQuery, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmdComando);
                da.Fill(ds);
                return ds;
            }

            catch (Exception e)
            {
                throw e;

            }

            finally
            {
                FechaBanco(conn);
            }
        }


        public OracleDataReader RetornaDataReader(string strQuery)
        {
            try
            {
                OracleDataReader dr;
                OracleCommand sqlComando = new OracleCommand(strQuery, AbreBanco());
                dr = sqlComando.ExecuteReader();
                return dr;
            }


            catch (Exception e)
            {
                throw e;

            }

            //finally
            //{
            //    FechaBanco(conn);
            //}
        }

        public void ExecutaComando(string strQuery)
        {
            OracleConnection conn;
            conn = AbreBanco();

            try
            {
                OracleCommand sqlComn = new OracleCommand(strQuery, conn);
                sqlComn.ExecuteNonQuery();
            }

            catch (Exception e)

            { throw e; }

            finally { FechaBanco(conn); }

        }


        public Int32 ExecutaScalar(string strQuery)
        {
            OracleConnection conn;
            conn = AbreBanco();

            try
            {
                OracleCommand sqlComn = new OracleCommand(strQuery, conn);

                sqlComn.Parameters.Add(new OracleParameter
                {
                    ParameterName = ":id",
                    OracleDbType = OracleDbType.Int32,
                    Direction = ParameterDirection.Output
                });

                sqlComn.ExecuteScalar();

                return Convert.ToInt32(sqlComn.Parameters[":id"].Value.ToString());
            }

            catch (Exception e)

            { throw e; }

            finally { FechaBanco(conn); }

        }


    }
}



