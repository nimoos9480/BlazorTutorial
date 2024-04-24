using BlazorApp.Services;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components.Pages
{
    // partial 키워드를 사용하는 이유 == 코드를 여러 파일에 나누어 작성할 수 있도록 하는 기능
    // 파일에는 클래스의 일부분을 작성할 수 있고, 컴파일러가 이들을 하나의 클래스로 합쳐서 처리 == 협업 시 유용
    public partial class FrmFileUploadTest
    {
        [Inject]
        public IFileUploadService FileUploadServiceReference { get; set; }

        private IFileListEntry[] selectedFiles;
        protected void HandleSelection(IFileListEntry[] files) // 배열로 온다!
        { 
            // 선택된 파일 배열에 담기
            this.selectedFiles = files;
        }
		protected async void UploadClick()
		{
			var file = selectedFiles.FirstOrDefault();
            if (file != null)
            {
                await FileUploadServiceReference.UploadAsync(file);
            }
		}
    }
}
