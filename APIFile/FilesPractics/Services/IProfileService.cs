namespace FilesPractics.Services
{
    public interface IProfileService
    {
        public ValueTask<string> CreateAvatarAsync(IFormFile formFile);
    }
}
