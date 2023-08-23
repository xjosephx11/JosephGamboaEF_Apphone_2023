using JosephGamboaEF_Apphone_2023.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace JosephGamboaEF_Apphone_2023.Views
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