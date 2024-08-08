using System;
using System.Collections.Generic;
using Theraputic.ViewModels;
using Theraputic.Views;
using Xamarin.Forms;

namespace Theraputic
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
