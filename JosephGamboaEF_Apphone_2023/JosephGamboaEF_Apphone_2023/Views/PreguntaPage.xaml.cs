using JosephGamboaEF_Apphone_2023.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JosephGamboaEF_Apphone_2023.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PreguntaPage : ContentPage
    {
        UserViewModel viewModel;
        public PreguntaPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new UserViewModel();
            LoadUserRolesAsync();
        }

        private async void LoadUserRolesAsync()
        {
            PkrUserRole.ItemsSource = await viewModel.GetUserRolesAsync();
        }

        private async void BtnAsk_Clicked(object sender, EventArgs e)
        {

        }

        private async void BtnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}