using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crud_aspnet_with_auth.Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter pelo menos 5 caracters")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage ="Email invalido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public List<Premium> Students { get; set; } = new();
    }
}
