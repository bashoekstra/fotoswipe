using MLToolkit.Forms.SwipeCardView.Core;
using SwipeCardView.Sample.DAL;
using SwipeCardView.Sample.Model;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;



namespace SwipeCardView.Sample.ViewModel
{
    public class TinderPageViewModel : BasePageViewModel
    {
        private ObservableCollection<Profile> _profiles { get;  set; }

        private uint _threshold;

        

        public TinderPageViewModel()
        {
            _profiles = new ObservableCollection<Profile>();
            Threshold = (uint)(App.ScreenWidth / 3);

            SwipedCommand = new Command<SwipedCardEventArgs>(OnSwipedCommand);
            DraggingCommand = new Command<DraggingCardEventArgs>(OnDraggingCommand);
            
            ClearItemsCommand = new Command(OnClearItemsCommand);
            AddItemsCommand = new Command(OnAddItemsCommand);
        }

        public ObservableCollection<Profile> Profiles
        {
            get => _profiles;
            set
            {
                _profiles = value;
                RaisePropertyChanged();
            }
        }

        public uint Threshold
        {
            get => _threshold;
            set
            {
                _threshold = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SwipedCommand { get; }

        public ICommand DraggingCommand { get; }

        public ICommand ClearItemsCommand { get; }

        public ICommand AddItemsCommand { get; }

        public Command LoadProfilesCommand { get; }

        public bool IsBusy { get; private set; }

        private void OnSwipedCommand(SwipedCardEventArgs eventArgs)
        {
        }

        private void OnDraggingCommand(DraggingCardEventArgs eventArgs)
        {
            switch (eventArgs.Position)
            {
                case DraggingCardPosition.Start:
                    return;

                case DraggingCardPosition.UnderThreshold:
                    break;

                case DraggingCardPosition.OverThreshold:
                    break;

                case DraggingCardPosition.FinishedUnderThreshold:
                    return;

                case DraggingCardPosition.FinishedOverThreshold:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnClearItemsCommand()
        {
            Profiles.Clear();
        }

        private void OnAddItemsCommand()
        {
        }

        public async void ExecuteLoadProfilesCommand()
        {
            IsBusy = true;

            try
            {
                _profiles.Clear();
                var profiles = await ProfileDataStore.GetProfilesAsync(true);
                foreach (var Profile in profiles)
                {
                    _profiles.Add(Profile);
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
    }
}