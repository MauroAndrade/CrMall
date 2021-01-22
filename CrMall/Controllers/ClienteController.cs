using CrMall.Models;
using Data.Models.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrMall.Controllers
{
    public class ClienteController : Controller
    {
        private readonly crmallContext _context;

        public ClienteController(crmallContext context)
        {
            _context = context;
        }

        // GET: ClienteController
        public ActionResult Index()
        {
            List<Clientes> clientes = _context.Clientes.ToList();
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            Clientes cliente = _context.Clientes.Find(id);

            return View(cliente);
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }

            try
            {
                Clientes cliente = new Clientes();

                cliente.Nome = clienteViewModel.Nome;
                cliente.Nascimento = clienteViewModel.Nascimento ?? DateTime.Now;
                cliente.Sexo = clienteViewModel.Sexo;
                cliente.Cep = clienteViewModel.Cep;
                cliente.Endereco = clienteViewModel.Endereco;
                cliente.Numero = clienteViewModel.Numero;
                cliente.Complemento = clienteViewModel.Complemento;
                cliente.Bairro = clienteViewModel.Bairro;
                cliente.Estado = clienteViewModel.Estado;
                cliente.Cidade = clienteViewModel.Cidade;

                _context.Clientes.Add(cliente);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel();
            try
            {
                Clientes cliente = _context.Clientes.Find(id);

                clienteViewModel.Id = cliente.Id;
                clienteViewModel.Nome = cliente.Nome;
                clienteViewModel.Nascimento = cliente.Nascimento;
                clienteViewModel.Sexo = cliente.Sexo;
                clienteViewModel.Cep = cliente.Cep;
                clienteViewModel.Endereco = cliente.Endereco;
                clienteViewModel.Numero = cliente.Numero;
                clienteViewModel.Complemento = cliente.Complemento;
                clienteViewModel.Bairro = cliente.Bairro;
                clienteViewModel.Estado = cliente.Estado;
                clienteViewModel.Cidade = cliente.Cidade;
            }
            catch (Exception e)
            {
                throw;
            }
            return View(clienteViewModel);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }

            try
            {
                Clientes cliente = _context.Clientes.Find(clienteViewModel.Id);

                cliente.Nome = clienteViewModel.Nome;
                cliente.Sexo = clienteViewModel.Sexo;
                cliente.Cep = clienteViewModel.Cep;
                cliente.Endereco = clienteViewModel.Endereco;
                cliente.Numero = clienteViewModel.Numero;
                cliente.Complemento = clienteViewModel.Complemento;
                cliente.Bairro = clienteViewModel.Bairro;
                cliente.Estado = clienteViewModel.Estado;
                cliente.Cidade = clienteViewModel.Cidade;

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                throw;
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {

            Clientes cliente = _context.Clientes.Find(id);

            return View(cliente);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Clientes clientes)
        {
            Clientes cliente = _context.Clientes.Find(id);
            try
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}
