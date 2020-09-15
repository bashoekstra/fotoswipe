using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwipeCardView.Sample.DAL
{
    public interface DataInterface<p>
    {
        Task<bool> AddProfileAsync(p profile);
        Task<bool> UpdateProfileAsync(p profile);
        Task<bool> DeleteProfileAsync(string Id);
        Task<p> GetProfileIdAsync(string Id);
        Task<IEnumerable<p>> GetProfilesAsync(bool forceRefresh = false);
        Task<p> GetProfileAsync(string email, string password);
    }
}
