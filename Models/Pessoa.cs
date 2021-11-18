using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PimViii.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Por favor preencha o campo 'Nome' ")]
        [StringLength(256)]
        public string NomePessoa { get; set; }

        public long Cpf { get; set; }

        public Endereco Enderecos { get; set; }

        public virtual List<Telefone> Telefones{ get; set; }

       
    }
}
