using System.ComponentModel;
using Theraputic.ViewModels;
using Xamarin.Forms;

namespace Theraputic.Views
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