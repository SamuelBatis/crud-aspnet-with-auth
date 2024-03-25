using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace crud_aspnet_with_auth.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o titulo do Premium")]
        [StringLength(80, ErrorMessage = "O Titulo deve conter até 80 caracteres")]
        [MinLength(5, ErrorMessage = "O Titulo deve conter pelo menos 5 caracteres")]
        [DisplayName("Titulo")]
        public string Title { get; set; }

        [DataType(DataType.DateTime)]
        // [GreaterThanToday]
        [DisplayName("Inicio")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Termino")]
        public DateTime EndDate { get; set; }


        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno invalido")]
        public DateTime StudentId { get; set; }
    }
}
