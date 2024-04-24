using BlazorInputFile;

namespace BlazorApp.Services
{
    public interface IFileUploadService
    {
        Task UploadAsync(IFileListEntry file);
    }
}
