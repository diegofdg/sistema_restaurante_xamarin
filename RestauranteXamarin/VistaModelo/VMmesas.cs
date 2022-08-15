using RestauranteXamarin.Modelo;
using RestauranteXamarin.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;

namespace RestauranteXamarin.VistaModelo
{
    public class VMmesas
    {
        public void dibujarMesasPorSalon(Msalon parametros, ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_mesas_por_salon_ventas", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@id_salon", parametros.Id_salon);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.StackTrace, "Ok");

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
    }
}
