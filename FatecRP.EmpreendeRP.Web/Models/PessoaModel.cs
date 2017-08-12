using DisciplineTeam.Area52.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FatecRP.EmpreendeRP.Web.Models
{
    public class PessoaModel : ModelBase
    {
        public void Create(Pessoa e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"EXEC cadPessoa @edicaoempreend, @cpf, @rg, @nome, @datanasc, @email, @cep, @logradouro, @numero, @bairro, 
                                @cidade, @uf, @fixo, @celular, @escolaridade, @trabalha, @ondtrabalha, @ehempreendedor, @cnpj, @necessidadeesp, @qualnecessidad, @sabendoevento, @outro";
            cmd.Parameters.AddWithValue("@edicaoempreend", e.EdicaoEmpreend);
            e.Cpf = (e.Cpf != null ? e.Cpf : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@cpf", e.Cpf);
            e.Rg = (e.Rg != null ? e.Rg : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@rg", e.Rg);
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            DateTime data = Convert.ToDateTime(e.DataNasc);
            cmd.Parameters.AddWithValue("@datanasc", data);
            e.Email = (e.Email != null ? e.Email : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@email", e.Email);
            e.Cep = (e.Cep != null ? e.Cep : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@cep", e.Cep);
            e.Logradouro = (e.Logradouro != null ? e.Logradouro : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@logradouro", e.Logradouro);
            e.Numero = (e.Numero != null ? e.Numero : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@numero", e.Numero);
            e.Bairro = (e.Bairro != null ? e.Bairro : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@bairro", e.Bairro);
            e.Localidade = (e.Localidade != null ? e.Localidade : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@cidade", e.Localidade);
            e.Uf = (e.Uf != null ? e.Uf : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@uf", e.Uf);
            e.Fixo = (e.Fixo != null ? e.Fixo : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@fixo", e.Fixo);
            e.Celular = (e.Celular != null ? e.Celular : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@celular", e.Celular);
            cmd.Parameters.AddWithValue("@escolaridade", e.Escolaridade);
            cmd.Parameters.AddWithValue("@trabalha", e.Trabalha);
            e.OndTrabalha = (e.OndTrabalha != null ? e.OndTrabalha : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@ondtrabalha", e.OndTrabalha);
            cmd.Parameters.AddWithValue("@ehempreendedor", e.EhEmpreendedor);
            e.Cnpj = (e.Cnpj != null ? e.Cnpj : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@cnpj", e.Cnpj);
            cmd.Parameters.AddWithValue("@necessidadeesp", e.NecessidadeEsp);
            e.QualNecessidad = (e.QualNecessidad != null ? e.QualNecessidad : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@qualnecessidad", e.QualNecessidad);
            cmd.Parameters.AddWithValue("@sabendoevento", e.SabendoEvento);
            e.Outro = (e.Outro != null ? e.Outro : ""); //Se receber valor nulo, insere no banco valor nulo
            cmd.Parameters.AddWithValue("@outro", e.Outro);

            cmd.ExecuteNonQuery();
        }
        public int ValidaCPF(string cpf)
        {
            int resposta;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"SELECT * FROM validarCPF WHERE CPF = @cpf";

            cmd.Parameters.AddWithValue("@cpf", cpf);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == false)
            {
                resposta = 0;
                return resposta;
            }
            else
            {
                resposta = 1;
                return resposta;
            }
        }
    }
}