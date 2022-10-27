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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre,string usuario, double montoi)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            lblMonto.Text = Convert.ToString(montoi);
            double total;
            total = ((((3000 - (Convert.ToDouble(lblMonto.Text)))/5)+150)*5)+ (Convert.ToDouble(lblMonto.Text));
            txtTotal.Text = Convert.ToString(total);
            lblMonto.Text = "Su pago es de:";

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alerta", "Fin del ejercicio", "Cerrar");
        }
    }
}