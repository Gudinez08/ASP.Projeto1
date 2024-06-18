using Microsoft.AspNetCore.Mvc;
using Exe.Models;

namespace Exe.Areas.Veiculo.Controllers
{
    [Area("Veiculo")]
    public class AutoController : Controller
    {

        public IActionResult Carro()
        {
            var carro = new Carro
            {
                Fabricante = "Bugatti",
                Nome = "La Voiture Noire",
                Categoria = "Esportivo",
                Transmissao = "Automática",
                Tipo = "Sedan"
            };
            return View(carro);
        }

        public IActionResult Moto()
        {
            var moto = new Moto
            {
                Fabricante = "Harley Davidson",
                Nome = "Cosmic Starship",
                Categoria = "Motocicleta",
                Cilindrada = 1200,
                Partida = "Elétrica"
            };
            return View(moto);
        }

        public IActionResult Veiculo()
        {
            var veiculo = new Veiculos
            {
                Fabricante = "Koenigsegg",
                Nome = "Jesko",
                Categoria = "Hipercarro"
            };
            return View(veiculo);
        }
    }
}
