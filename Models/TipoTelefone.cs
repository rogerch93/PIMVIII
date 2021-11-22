﻿using System.ComponentModel.DataAnnotations;

namespace PimViii.Models
{
    public class TipoTelefone
    {
        public int TipoTelefoneId { get; set; }
        
        [Display(Name = "Tipo de Telefone")]
        [StringLength(10)]
        [Required(ErrorMessage = "Por favor preencha o campo 'Tipo de Telefone'")]
        public string Tipo { get; set; }

        [Display(Name ="Usuario Cadastrado")]
        public int PessoaId { get; set; }

        public virtual Pessoa Pessoa { get; set; }

    }
}
