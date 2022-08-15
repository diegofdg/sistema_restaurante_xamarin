using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RestauranteXamarin.Servicio
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = "Data Source=192.168.1.7;Initial Catalog=BASEBRIRESTCSHARP;Integrated Security=False;User Id=diego;Password=root";
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
