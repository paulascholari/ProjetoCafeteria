using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoCafeteria.Classes
{
    public class BD
    {
        private static string stringConexao { get; set; }
        static SqlConnection con;
        public static void AbreBanco()
        {
            stringConexao = @"Data Source=BOT0626782W10-2; Initial Catalog=LePetit;User Id=sa;Password=sasenac";
            //stringConexao = @"Data Source=DESKTOP-VJPS1VM\SQLEXPRESS; Initial Catalog=LePetit;User Id=sa;Password=sasenac";

            con = new SqlConnection();
            con.ConnectionString = stringConexao;
            con.Open();
        }

        public static void FechaBanco()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static DataTable RetornaDatatable(string sql)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;

            try
            {
                SqlDataReader dr = cmd.ExecuteReader(); 
                dt.Load(dr);

                dr.Close();

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
          
        }

        public static Int32 ExecutaComando(string sql, bool inclusão)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            if (inclusão)
            {
                cmd.CommandText = "SELECT @@IDENTITY";
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            return 0;
        }

        public static string RetornaValor(string tabela, int codigo, string campo)
        {
            string valor = "";

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select " + campo + " from " + tabela + " where codigo = " + codigo;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                valor = dr[0].ToString();
            }

            dr.Close();

            return valor;
        }

    }
}
