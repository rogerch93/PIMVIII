using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PimViii.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }

        [StringLength(256)]
        [Required(ErrorMessage = "Por favor preencha o campo 'Logradouro'")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo 'Numero'")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo 'CEP'")]
        public int Cep { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo 'Bairro'")]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo 'Cidade'")]
        [StringLength(30)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo 'Estado'")]
        [StringLength(20)]
        public string Estado { get; set; }
    }
}
