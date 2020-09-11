using MLToolkit.Forms.SwipeCardView.Core;
using SwipeCardView.Sample.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeCardView.Sample.ViewModel
{
    public class TinderPageViewModel : BasePageViewModel
    {
        private ObservableCollection<Profile> _profiles = new ObservableCollection<Profile>();

        private uint _threshold;

        public TinderPageViewModel()
        {
            InitializeProfiles();

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

        private void InitializeProfiles()
        {
            // Photos are from https://unsplash.com/. Name and Age values are fictional.

            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Laura", Age = 24, Gender = Gender.Female, Photo = "p705193.jpg", City = "Ede" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Sophia", Age = 21, Gender = Gender.Female, Photo = "p597956.jpg", City = "Den-Haag" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Anne", Age = 19, Gender = Gender.Female, Photo = "p497489.jpg", City = "Amersfoort" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Yvonne ", Age = 27, Gender = Gender.Female, Photo = "p467499.jpg", City = "Amersfoort" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Abby", Age = 25, Gender = Gender.Female, Photo = "p589739.jpg", City = "Den-Haag" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Andressa", Age = 28, Gender = Gender.Female, Photo = "p453095.jpg", City = "Amsterdam" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "June", Age = 29, Gender = Gender.Female, Photo = "p503001.jpg", City = "Amersfoort" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Kim", Age = 22, Gender = Gender.Female, Photo = "p627958.jpg", City = "Nijmegen" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Denesha", Age = 26, Gender = Gender.Female, Photo = "p474893.jpg", City = "Den-Haag" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Sasha", Age = 23, Gender = Gender.Female, Photo = "p458914.jpg", City = "Wageningen" });

            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Austin", Age = 28, Gender = Gender.Male, Photo = "p378674.jpg", City = "Ede" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "James", Age = 32, Gender = Gender.Male, Photo = "p398931.jpg", City = "Amsterdam" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Chris", Age = 27, Gender = Gender.Male, Photo = "p401107.jpg", City = "Nijmegen" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Alexander", Age = 30, Gender = Gender.Male, Photo = "p731150.jpg", City = "Den-Haag" });
            Profiles.Add(new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Steve", Age = 31, Gender = Gender.Male, Photo = "p327144.jpg", City = "Wageningen" });
        }
    }
}