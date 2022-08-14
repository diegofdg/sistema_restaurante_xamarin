using RestauranteXamarin.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Xamarin.Forms;


namespace RestauranteXamarin.VistaModelo
{
    public class VMusuarios
    {
        public void dibujarUsuarios(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios where Estado='ACTIVO'", CONEXIONMAESTRA.conectar);
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
