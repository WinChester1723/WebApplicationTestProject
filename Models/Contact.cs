using System.ComponentModel.DataAnnotations;

namespace WebApplicationTestProject.Models
{
    public class Contact
    {
        [Display(Name="Write Name")]
        [Required(ErrorMessage ="You need enter Name")]
        public string Name { get; set; }
        [Display(Name = "Write Surname")]
        [Required(ErrorMessage = "You need enter Surname")]
        public string Surname { get; set; }
        [Display(Name = "Write Age")]
        [Required(ErrorMessage = "You need enter Age")]
        public int Age { get; set; }
        [Display(Name = "Write Email")]
        [Required(ErrorMessage = "You need enter Email")]
        public string Email { get; set; }
        [Display(Name = "Write Message")]
        [Required(ErrorMessage = "You need enter Message")]
        [StringLength(30,ErrorMessage ="Text max 30 symbols")]
        public string Message { get; set; }
    }
}
