using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteProject.Models
{
    public class ContactChildModel
    {
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Número de Telefone")]
        [DataType(DataType.PhoneNumber)]
        public int NumerodeTelefone { get; set; }

        [Display(Name = "Orçamento")]
        public int Orcamento { get; set; }

        [Display(Name = "Requisitos")]
        public string Requisitos { get; set; }
    }
}