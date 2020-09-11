using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using mobile_test.Models;
using mobile_test.Views;

namespace mobile_test.ViewModels
{
    public class accauntViewModel : BaseViewModel
    {
        private Item _selectedItem;

        public ObservableCollection<Item> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<Item> ItemTapped { get; }

        
        public string Id { get; set; }
       
        public accauntViewModel()
        {
            Title = "My Accaunt";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }


        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    if(item.useridentivier == 1)
                    {
                        Items.Add(item);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async void OnAppearing()
        {
            IsBusy = true;
            await ExecuteLoadItemsCommand();
        }


        private async void gotoaccaunt()
        {

            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }
    }

}
