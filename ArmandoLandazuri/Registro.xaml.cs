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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "El usuario es:" + usuario;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double montoinicial = Convert.ToDouble(txtMontoInicial.Text);
            double valorsemestre = 3000;
            double recargo = valorsemestre * 5 / 100;
            double cuota=0;
            string r;
            cuota = (valorsemestre - montoinicial) / 5;
            r = Convert.ToString(cuota+recargo);
            txtPagoMensual.Text = r;
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            double montoi;
            montoi = Convert.ToDouble(txtPagoMensual.Text);
            await Navigation.PushAsync(new Resumen(txtNombre.Text,lblUsuario.Text,montoi));
        }
    }
}