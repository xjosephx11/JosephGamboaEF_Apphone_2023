using JosephGamboaEF_Apphone_2023.Services;
using JosephGamboaEF_Apphone_2023.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JosephGamboaEF_Apphone_2023
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new BienvenidoPage());
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
