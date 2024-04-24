using BlazorInputFile;

namespace BlazorApp.Services
{
    public class FileUploadService : IFileUploadService    // IFileUploadService 상속
    {
        private readonly IWebHostEnvironment _environment;

        // IWebHostEnvironment은 파일 업로드 서비스에서 환경을 읽거나 파일 경로를 구성하는 데 사용 => 의존성 주입
        public FileUploadService(IWebHostEnvironment env)
        {
            this._environment = env;
        }
        public async Task UploadAsync(IFileListEntry fileEntry) // 파일 업로드 기능 구현
        {
            // 파일 업로드 경로 결정(루트경로, 저장될위치, 파일이름)
            var path = Path.Combine(_environment.WebRootPath, "Upload", fileEntry.Name);

            // 메모리 스트림 생성해서 복사
            var ms = new MemoryStream();
            await fileEntry.Data.CopyToAsync(ms);

            // 업로드된 파일 저장(경로, 파일생성, 액세스권한)
            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }
        }
    }
}
