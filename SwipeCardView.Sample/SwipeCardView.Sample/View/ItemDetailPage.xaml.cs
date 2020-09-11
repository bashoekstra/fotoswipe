using System.ComponentModel;
using Xamarin.Forms;
using mobile_test.ViewModels;

namespace mobile_test.Views
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