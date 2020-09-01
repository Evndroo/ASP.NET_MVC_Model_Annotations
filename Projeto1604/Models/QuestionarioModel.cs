using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto1604.Models
{
    public class QuestionarioModel
    {
        [Required]
        [DisplayName("Tipo de projeto")]
        public string TipoProjeto { get; set; }

        [Required(ErrorMessage ="O CEP deve ser informado")]
        [RegularExpression(@"^\d{8}$|^\d{5}-\d{3}$",ErrorMessage ="O formato de código postal é 00000000 ou 000000-000")]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage ="O contato deve ser informado")]
        [StringLength(50,MinimumLength =5)]
        public string Contato { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage ="O telefone deve ser informado")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Forneça o número de telefone no formato (00)000-0000")]
        [DisplayName("Número de Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage ="Descrição é obrigatório")]
        [StringLength(5000, MinimumLength =20)]
        [DataType(DataType.MultilineText)]
        [DisplayName("Descrição do projeto")]
        public string Descricao { get; set; }

    }
}