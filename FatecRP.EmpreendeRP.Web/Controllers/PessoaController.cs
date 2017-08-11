using FatecRP.EmpreendeRP.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FatecRP.EmpreendeRP.Web.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pessoa e)
        {
            try
            {
                using (PessoaModel model = new PessoaModel())
                {
                    e.EdicaoEmpreend = "2ª"; //Gambiarra próvisória pra adicionar a edição do EmpreendeRP
                    model.Create(e);        // Chama o método Create e cadastra a Pessoa no Banco
                    TempData["Sucesso"] = "Cadastro realizado com sucesso!"; // Mensagem utilizada para notificar o usuário do sucesso do cadastro
                }
                return RedirectToAction("Index", "Pessoa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught", ex);
                TempData["Falha"] = "Falha no cadastro!"; // Mensagem utilizada para notificar o usuário da falha no cadastro
                return RedirectToAction("Index", "Pessoa");
            }
            
        }
    }
}