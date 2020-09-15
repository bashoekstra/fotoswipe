using System.ComponentModel;
using Xamarin.Forms;
using SwipeCardView.Sample.ViewModel;

namespace SwipeCardView.Sample.View
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