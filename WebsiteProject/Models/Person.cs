
using System.ComponentModel.DataAnnotations;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace WebsiteProject.Models
{
    public class PersonModel
    {
        //public Person(IPublishedContent content) : base(content)
        //{
        //}

        ////public Person()
        ////{
        ////    Umbraco.Web.Composing.Current.UmbracoContext.
        ////    base(null);
        ////}

        [Display(Name = "Primeiro e último Nome")]
        
        public string PrimeiroNome { get; set; }

        [Display(Name = "Data de Nascimento")]
        
        [DataType(DataType.DateTime)]
        public string DatadeNascimento { get; set; }

        [Display(Name = "Peso")]

        public int Peso { get; set; }

        [Display(Name = "Altura")]

        public int Altura { get; set; }

        [Display(Name = "Cor do Cabelo")]
        
        public string CordoCabelo { get; set; }

        [Display(Name = "Cor dos Olhos")]
        
        public string CordeOlhos { get; set; }

        [Display(Name = "Sexo")]
        
        public Sexo SexoPessoa { get; set; }

        [Display(Name = "Imagem")]

        public HttpPostedFileBase Imagem { get; set; }




    }
}