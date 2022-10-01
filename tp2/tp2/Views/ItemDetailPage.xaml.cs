using System.ComponentModel;
using tp2.ViewModels;
using Xamarin.Forms;

namespace tp2.Views
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