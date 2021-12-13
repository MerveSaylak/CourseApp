using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email adresinizi giriniz.")]
        [EmailAddress(ErrorMessage ="Email adresinizi doğru giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon numaranızı giriniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılma durumunuz nedir?")]
        public bool? Confirm { get; set; }//true,false,null değer false
    }
}
