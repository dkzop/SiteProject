﻿
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace WebsiteProject.Models
{
    public class PersonModel
    {

        [Display(Name = "Primeiro e último Nome")]
        [Required]
        public string PrimeiroNome { get; set; }

        [Display(Name = "Data de Nascimento")]
        
        [DataType(DataType.DateTime)]
        public string DatadeNascimento { get; set; }

        [Display(Name = "Peso")]

        public int? Peso { get; set; }

        [Display(Name = "Altura")]

        public int? Altura { get; set; }

        [Display(Name = "Cor do Cabelo")]
        
        public string CordoCabelo { get; set; }

        [Display(Name = "Cor dos Olhos")]
        
        public string CordeOlhos { get; set; }

        [Display(Name = "Sexo")]
        
        public Sexo SexoPessoa { get; set; }

        [Display(Name = "ImagemParaCarregar")]

        public HttpPostedFileBase ImagemParaCarregar { get; set; }

        [Display(Name = "ImagemUrl")]
        public string ImagemUrl { get; set; }

    }
}