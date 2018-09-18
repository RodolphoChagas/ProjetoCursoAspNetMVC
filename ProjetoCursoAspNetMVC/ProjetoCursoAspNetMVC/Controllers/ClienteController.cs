using ProjetoCursoAspNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCursoAspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {

            var cliente = new Cliente()
            {
                Nome = "ASP",
                SobreNome = "NET",
                DataCadastro = DateTime.Now,
                ClienteId = 1
            };
            
            return View(cliente);
        }


        public ActionResult ListaClientes()
        {
            var clientes = new List<Cliente>()
            {
                new Cliente() { Nome = "João", SobreNome = "Pedro", DataCadastro = DateTime.Now, ClienteId = 1 },
                new Cliente() { Nome = "Fulano", SobreNome = "Beltrano", DataCadastro = DateTime.Now, ClienteId = 2 }
            };


            return View(clientes);
        }

        public ActionResult Pesquisa(int? id, string nome)
        {
            var clientes = new List<Cliente>()
            {
                new Cliente() { Nome = "João", SobreNome = "Pedro", DataCadastro = DateTime.Now, ClienteId = 1 },
                new Cliente() { Nome = "Fulano", SobreNome = "Beltrano", DataCadastro = DateTime.Now, ClienteId = 2 }
            };


            var clientesFiltrados = clientes.Where(cliente => cliente.ClienteId == id).ToList();

            return View("ListaClientes", clientesFiltrados);
        }
    }
}