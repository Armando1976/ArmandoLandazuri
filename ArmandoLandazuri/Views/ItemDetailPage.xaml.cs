using ArmandoLandazuri.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ArmandoLandazuri.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}