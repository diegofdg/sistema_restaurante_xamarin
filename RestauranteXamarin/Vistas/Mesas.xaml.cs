using RestauranteXamarin.Modelo;
using RestauranteXamarin.VistaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestauranteXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mesas : ContentPage
    {
        public Mesas()
        {
            InitializeComponent();
            dibujarSalones();

        }
        int idsalon;
        public void dibujarSalones()
        {
            DataTable dt = new DataTable();
            VMsalon funcion = new VMsalon();
            funcion.dibujarsalones(ref dt);
            foreach (DataRow rdr in dt.Rows)
            {
                Button b = new Button();
                b.Text = rdr["Salon"].ToString();
                b.CommandParameter = rdr["Id_salon"].ToString();
                b.HeightRequest = 50;
                b.WidthRequest = 150;
                b.BackgroundColor = Color.FromRgb(37, 37, 37);
                b.TextColor = Color.White;
                PanelSalones.Children.Add(b);
                b.Clicked += B_Clicked;
            }
        }

        private void B_Clicked(object sender, EventArgs e)
        {
            idsalon = Convert.ToInt32(((Button)sender).CommandParameter);
            dibujarMesasPorSalon();
        }
        public void dibujarMesasPorSalon()
        {
            PanelMesas.Children.Clear();
            DataTable dt = new DataTable();
            Msalon parametros = new Msalon();
            VMmesas funcion = new VMmesas();
            parametros.Id_salon = idsalon;
            funcion.dibujarMesasPorSalon(parametros, ref dt);            

            foreach (DataRow rdr in dt.Rows)
            {
                string estado;
                Button b = new Button();
                b.Text = rdr["Mesa"].ToString();
                b.HeightRequest = 110;
                b.WidthRequest = 100;
                estado = rdr["Estado_de_Disponibilidad"].ToString();
                if (estado == "LIBRE")
                {
                    b.BackgroundColor = Color.FromRgb(2, 197, 75);

                }
                else
                {
                    b.BackgroundColor = Color.FromRgb(221, 80, 67);
                }
                PanelMesas.Children.Add(b);

            }
        }
    }
}