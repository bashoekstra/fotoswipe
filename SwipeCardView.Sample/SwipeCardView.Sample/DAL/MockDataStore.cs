using SwipeCardView.Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;
using Profile = SwipeCardView.Sample.Model.Profile;

namespace SwipeCardView.Sample.DAL
{
    public class MockDataStore : DataInterface<Profile>
    {
        readonly List<Profile> profiles;

        public MockDataStore()
        {
            profiles = new List<Profile>()
            {
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Laura", Age = 24, Gender = Gender.Female, Photo = "p705193.jpg", City = "Ede", Prefference = Gender.Male, Email = "lol@123.com", PassWord = "lol123" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Sophia", Age = 21, Gender = Gender.Female, Photo = "p597956.jpg", City = "Den-Haag", Prefference = Gender.Male, Email = "lol@456.com", PassWord = "lol456" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Anne", Age = 19, Gender = Gender.Female, Photo = "p497489.jpg", City = "Amersfoort", Prefference = Gender.Female, Email = "lol@789.com", PassWord = "lol789" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Yvonne ", Age = 27, Gender = Gender.Female, Photo = "p467499.jpg", City = "Amersfoort", Prefference = Gender.Male, Email = "lol@111.com", PassWord = "lol111" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Abby", Age = 25, Gender = Gender.Female, Photo = "p589739.jpg", City = "Den-Haag", Prefference = Gender.Female, Email = "lol@222.com", PassWord = "lol222" }, 
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Andressa", Age = 28, Gender = Gender.Female, Photo = "p453095.jpg", City = "Amsterdam", Prefference = Gender.Male, Email = "lol@333.com", PassWord = "lol333" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "June", Age = 29, Gender = Gender.Female, Photo = "p503001.jpg", City = "Amersfoort", Prefference = Gender.Male, Email = "lol@444.com", PassWord = "lol444" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Kim", Age = 22, Gender = Gender.Female, Photo = "p627958.jpg", City = "Nijmegen", Prefference = Gender.Female, Email = "lol@555.com", PassWord = "lol555" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Denesha", Age = 26, Gender = Gender.Female, Photo = "p474893.jpg", City = "Den-Haag", Prefference = Gender.Male, Email = "lol@666.com", PassWord = "lol666" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Sasha", Age = 23, Gender = Gender.Female, Photo = "p458914.jpg", City = "Wageningen", Prefference = Gender.Male, Email = "lol@777.com", PassWord = "lol777" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Austin", Age = 28, Gender = Gender.Male, Photo = "p378674.jpg", City = "Ede", Prefference = Gender.Female, Email = "lol@888.com", PassWord = "lol888" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "James", Age = 32, Gender = Gender.Male, Photo = "p398931.jpg", City = "Amsterdam", Prefference = Gender.Male, Email = "lol@999.com", PassWord = "lol999" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Chris", Age = 27, Gender = Gender.Male, Photo = "p401107.jpg", City = "Nijmegen", Prefference = Gender.Male, Email = "lol@.000", PassWord = "lol000" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Alexander", Age = 30, Gender = Gender.Male, Photo = "p731150.jpg", City = "Den-Haag", Prefference = Gender.Female, Email = "lol@1010.com", PassWord = "lol1010" },
                new Profile { ProfileId = Guid.NewGuid().ToString(), Name = "Steve", Age = 31, Gender = Gender.Male, Photo = "p327144.jpg", City = "Wageningen", Prefference = Gender.Male, Email = "lol@1111.com", PassWord = "lol1111" }
            };
        }

        public async Task<bool> AddProfileAsync(Profile profile)
        {
            profiles.Add(profile);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProfileAsync(string Id)
        {
            var oldProfile = profiles.Where((Profile arg) => arg.ProfileId == Id).FirstOrDefault();
            profiles.Remove(oldProfile);

            return await Task.FromResult(true);
        }

        public async Task<IEnumerable<Profile>> GetProfilesAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(profiles);
        }

        public async Task<Profile> GetProfileIdAsync(string Id)
        {
            return await Task.FromResult(profiles.FirstOrDefault(p => p.ProfileId == Id));
        }

        public async Task<bool> UpdateProfileAsync(Profile profile)
        {
            var oldProfile = profiles.Where((Profile arg) => arg.ProfileId == profile.ProfileId).FirstOrDefault();
            profiles.Remove(oldProfile);
            profiles.Add(profile);

            return await Task.FromResult(true);
        }
    }
}
