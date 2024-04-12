using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]   // 공백 입력하는 것은 막지 못함
        [Required]                                                    // 공백 입력하는 것은 막지 못함
        public string? Title { get; set; } // ?는 속성이 null 허용임을 나타냄


                                                                                        // DisplayFormat 특성은 날짜 형식을 명시적으로 지정하는 데 사용
                                                                                        // ApplyFormatInEditMode 설정은 값이 편집을 위해 텍스트 상자에 표시될 때 서식 지정도 적용되어야 함을 지정
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        /*[Display(Name = "Release Date")]  */              // display 특성은 필드의 이름으로 표시할 내용을 지정 ( "ReleaseDate" 대신 "Release Date" )
        [DataType(DataType.Date)]                          
        public DateTime ReleaseDate { get; set; }        /* DataType 특성은 날짜 형식(Date)을 지정
                                                                                      => 사용자가 날짜 필드에 시간 정보를 입력할 필요가 없음
                                                                                      => 시간 정보 없이 날짜만 표시됨 */

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }


        [Column(TypeName = "decimal(18, 2)")]       // Price를 데이터베이스의 통화에 올바르게 매핑하기 위함 
        [Range(1, 100)]
        [DataType(DataType.Currency)]               // 값 형식(예: decimal, int, float, DateTime)은 기본적으로 필수적이며 [Required] 특성이 필요 없음
        public decimal Price {  get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]  // 입력할 수 있는 문자를 제한 - 문자만 사용, 첫번째 문자는 대문자, 특수문자와 숫자 허용
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }


    /*일반적으로 DataType 특성을 사용하는 것을 추천
       장점 
        - 브라우저는 HTML5 기능을 활성화 가능 (예: 달력 컨트롤, 로캘에 적합한 통화 기호, 이메일 링크 등)
        - 브라우저는 사용자의 로컬에 따른 올바른 서식을 사용하여 데이터를 렌더링
        - DataType 특성을 사용하면 MVC가 데이터 렌더링에 적합한 필드 템플릿을 선택 가능 
                (DisplayFormat만 사용할 경우 문자열 템플릿을 사용)
     */
}
