using Ballistico.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Ballistico.Views
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