using System.ComponentModel.DataAnnotations;

namespace PIMVIII.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Por favor preencha o campo com um Nome.")]
        [Display(Name = "Nome Completo")]
        [StringLength(100)]
        public string NomePessoa { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo com um CPF.")]
        [Display(Name = "CPF")]
        [StringLength(11)]
        public long Cpf { get; set; }
    
        [Required(ErrorMessage = "Por favor preencha o campo com um Endereço.")]
        [Display(Name = "Endereço")]
        [StringLength(150)]
        public List<Endereco> Enderecos { get; set; }

        [Required(ErrorMessage = "Por favor preencha o campo com algum tipo de Telefone")]
        [Display(Name = "Telefone Para Contato")]
        [StringLength(11)]
        public List<Telefone> Telefones { get; set; }

    }
}