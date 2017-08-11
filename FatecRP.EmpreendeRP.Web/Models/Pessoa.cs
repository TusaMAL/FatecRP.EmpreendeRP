using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FatecRP.EmpreendeRP.Web.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Edição do evento é obrigatória")]
        public string EdicaoEmpreend { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "Data de nascimento é obrigatória")]
        public string DataNasc { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        [Required(ErrorMessage = "Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "Numero é obrigatório")]
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Fixo { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage = "Escolaridade é obrigatória")]
        public string Escolaridade { get; set; }
        [Required(ErrorMessage = "Trabalha é obrigatório")]
        public string Trabalha { get; set; }
        public string OndTrabalha { get; set; }
        [Required(ErrorMessage = "Empreendedor é obrigatório")]
        public string EhEmpreendedor { get; set; }
        public string Cnpj { get; set; }
        [Required(ErrorMessage = "Necessidades especiais é obrigatória")]
        public string NecessidadeEsp { get; set; }
        public string QualNecessidad { get; set; }
        public string SabendoEvento { get; set; }
    }
}