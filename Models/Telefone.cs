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

        public int TipoTelefoneId { get; set; }
        public TipoTelefone TipoTelefones { get; set; }

    }
}
