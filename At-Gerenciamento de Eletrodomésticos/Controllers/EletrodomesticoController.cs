using At_Gerenciamento_de_Eletrodomésticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace At_Gerenciamento_de_Eletrodomésticos.Controllers
{
    public class EletrodomesticoController : Controller
    {
        public IActionResult Index()
        {

            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira{ Marca = "Electrolux", Modelo = "IF45S 127V", ConsumoEnergetico = 42, CapacidadeLitros = 410, TemFreezer = true},
                new Geladeira{ Marca = "Philco", Modelo = "Duplex", ConsumoEnergetico = 2022, CapacidadeLitros = 413, TemFreezer = true },
                new Televisor{ Marca = "LG", Modelo = "50UR871C0SA", ConsumoEnergetico = 2022, EhSmart = true, TamanhoTela = 50 }

            };
            return View(eletrodomesticos);
        }
    }
}