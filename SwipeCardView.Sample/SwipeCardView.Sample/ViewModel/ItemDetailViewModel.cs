using System;
using System.Diagnostics;
using System.Threading.Tasks;
using mobile_test.Models;
using Xamarin.Forms;

namespace mobile_test.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string fullname;
        private int age;
        private string adress;
        private string city;
        public int useridentivier;
        public string Id { get; set; }
        

        public string Fullname
        {
            get => fullname;
            set => SetProperty(ref fullname, value);
        }

        public int Useridentivier
        {
            get => useridentivier;
            set => SetProperty(ref useridentivier, value);
        }
        public int Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }
        public string Adress
        {
            get => adress;
            set => SetProperty(ref adress, value);
        }
        public string City
        {
            get => city;
            set => SetProperty(ref city, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                if (item.middlename == "")
                {
                    Fullname = item.firstname + " " + item.lastname;
                }
                else
                {
                    Fullname = item.firstname + "" + item.middlename + "" + item.lastname;
                }
                Age = item.age;
                Adress = item.adress;
                City = item.city;
                Useridentivier = item.useridentivier;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
