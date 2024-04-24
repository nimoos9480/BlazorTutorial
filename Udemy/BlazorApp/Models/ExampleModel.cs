using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class ExampleModel
    {
        [Required(ErrorMessage ="이름은 필수입니다.")] // 반드시 입력
        [StringLength(10, ErrorMessage ="이름을 10자 이하로 입력하세요.")] // 문자열길이 설정, 초과시 에러메세지
        public string Name { get; set; }
    }
}
