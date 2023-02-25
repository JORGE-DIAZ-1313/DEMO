using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DEMO.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

       var  Page = new views.Page2();
            
        private async void txtboton1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("SALUDOS:", txtNombre1.Text + " " +txtapellido1.Text, "ok");
        }
    }
}