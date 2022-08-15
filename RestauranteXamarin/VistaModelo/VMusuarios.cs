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
		public void validarUsuario(Musuarios parametros, ref int id)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("validarUsuario", CONEXIONMAESTRA.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@password", parametros.Password);
				cmd.Parameters.AddWithValue("@login", parametros.Login);
				id = Convert.ToInt32(cmd.ExecuteScalar());


			}
			catch (Exception ex)
			{
				id = 0;

			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
	}
}
