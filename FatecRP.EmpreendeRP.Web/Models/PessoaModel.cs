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
                                @cidade, @uf, @fixo, @celular, @escolaridade, @trabalha, @ondtrabalha, @ehempreendedor, @cnpj, @necessidadeesp, @qualnecessidad, @sabendoevento";
            cmd.Parameters.AddWithValue("@edicaoempreend", e.EdicaoEmpreend);
            cmd.Parameters.AddWithValue("@cpf", e.Cpf);
            cmd.Parameters.AddWithValue("@rg", e.Rg);
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            DateTime data = Convert.ToDateTime(e.DataNasc);
            cmd.Parameters.AddWithValue("@datanasc", data);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@cep", e.Cep);
            cmd.Parameters.AddWithValue("@logradouro", e.Logradouro);
            cmd.Parameters.AddWithValue("@numero", e.Numero);
            cmd.Parameters.AddWithValue("@bairro", e.Bairro);
            cmd.Parameters.AddWithValue("@cidade", e.Localidade);
            cmd.Parameters.AddWithValue("@uf", e.Uf);
            cmd.Parameters.AddWithValue("@fixo", e.Fixo);
            cmd.Parameters.AddWithValue("@celular", e.Celular);
            cmd.Parameters.AddWithValue("@escolaridade", e.Escolaridade);
            cmd.Parameters.AddWithValue("@trabalha", e.Trabalha);
            cmd.Parameters.AddWithValue("@ondtrabalha", e.OndTrabalha);
            cmd.Parameters.AddWithValue("@ehempreendedor", e.EhEmpreendedor);
            cmd.Parameters.AddWithValue("@cnpj", e.Cnpj);
            cmd.Parameters.AddWithValue("@necessidadeesp", e.NecessidadeEsp);
            cmd.Parameters.AddWithValue("@qualnecessidad", e.QualNecessidad);
            cmd.Parameters.AddWithValue("@sabendoevento", e.SabendoEvento);

            cmd.ExecuteNonQuery();
        }
    }
}