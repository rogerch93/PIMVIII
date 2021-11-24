using System.ComponentModel.DataAnnotations;

namespace PimViii.Models
{
    public class Telefone 
    {
        public int TelefoneId { get; set; }

        [Required(ErrorMessage ="Preencha todos os campos")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Preencha todos os campos")]
        public int DDD { get; set; }

        [Display(Name ="Tipo de Telefone")]
        public int TipoTelefoneId { get; set; }

        [Display(Name = "Tipo de Telefone")]
        public TipoTelefone TipoTelefones { get; set; }

    }
}
