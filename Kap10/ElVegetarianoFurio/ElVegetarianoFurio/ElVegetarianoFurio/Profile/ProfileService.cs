using System.Threading.Tasks;

namespace ElVegetarianoFurio.Profile
{
    public class ProfileService : IProfileService
    {
        private Profile _profile = new Profile();
        public Task<Profile> GetAsync()
        {
            return Task.FromResult(_profile);
        }

        public Task<bool> SaveAsync(Profile profile)
        {
            _profile = profile;
            return Task.FromResult(true);
        }
    }
}