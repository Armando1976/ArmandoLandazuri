using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArmandoLandazuri
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "armando2022";
            string password= "uisrael2022";
            string tusuario = txtUsuario.Text;
            string tpassword = txtClave.Text;
            if (usuario == tusuario & password == tpassword)
            {
                DisplayAlert("Alerta", "Usuario Correcto", "Cerrar");
                await Navigation.PushAsync(new Registro(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario Incorrecto", "Cerrar");
            }

        }
    }
}