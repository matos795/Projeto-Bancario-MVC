using Microsoft.AspNetCore.Mvc;
using SistemaBancario.Models;

namespace SistemaBancario.Controllers
{
    public class ContaController : Controller
    {
        private static List<Conta> listaContas = new List<Conta>();

        public IActionResult Listar()
        {
            return View(listaContas);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(string nomeCliente, decimal saldoInicial, string tipoConta)
        {
            Conta conta;

            if (tipoConta == "Corrente")
            {
                conta = new ContaCorrente(nomeCliente, saldoInicial);
            }
            else if (tipoConta == "Poupança")
            {
                conta = new ContaPoupanca(nomeCliente, saldoInicial);
            } 
            else
            {
                TempData["Erro"] = "Tipo de conta inválido.";
                return RedirectToAction("Cadastrar");
            }
            if (conta.ValidarAbertura())
            {
                listaContas.Add(conta);
                TempData["Sucesso"] = "Conta cadastrada com sucesso!";
                return RedirectToAction("Index", "Home");
            } 
            else
            {
                TempData["Erro"] = "A Conta não pôde ser aberta. Verifique os critérios";
                return RedirectToAction("Cadastrar");
            }
        }
    }
}
