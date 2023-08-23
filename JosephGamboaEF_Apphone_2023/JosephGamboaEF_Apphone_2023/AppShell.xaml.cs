using JosephGamboaEF_Apphone_2023.ViewModels;
using JosephGamboaEF_Apphone_2023.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JosephGamboaEF_Apphone_2023
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
