using RestauranteXamarin.Modelo;
using RestauranteXamarin.Servicio;
using RestauranteXamarin.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestauranteXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarcarContraseña : ContentPage
    {
        public MarcarContraseña()
        {
            InitializeComponent();
        }
        public static string login;
        public int idusuario;
        private void btn7_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 7;
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 8;

        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 9;

        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 4;

        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 5;

        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 6;

        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 1;

        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 2;

        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 3;

        }

        private void btnborrar_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text = "";

        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            txtContraseña.Text += 0;
        }

        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Error", "Datos incorrectos", "Ok");
        }

        private void btnBorrarCaract_Clicked(object sender, EventArgs e)
        {
            int contador;
            contador = txtContraseña.Text.Count();
            if (contador > 0)
            {

                txtContraseña.Text = txtContraseña.Text.Substring(0, txtContraseña.Text.Count() - 1);
            }

        }

        private void txtContraseña_TextChanged(object sender, TextChangedEventArgs e)
        {
            validarContraseña();
        }
        private void validarContraseña()
        {
            Musuarios parametros = new Musuarios();
            VMusuarios funcion = new VMusuarios();
            parametros.Password = Bases.Encriptar(txtContraseña.Text);
            parametros.Login = login;
            funcion.validarUsuario(parametros, ref idusuario);
            if (idusuario > 0)
            {
                ((NavigationPage)this.Parent).PushAsync(new Ventas());
            }
        }
    }
}