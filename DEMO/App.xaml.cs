using DEMO.views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DEMO
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new views.Page1());
            Page.BindingContext= Page1
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
