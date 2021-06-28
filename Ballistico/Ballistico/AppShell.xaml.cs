using Ballistico.ViewModels;
using Ballistico.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Ballistico
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
