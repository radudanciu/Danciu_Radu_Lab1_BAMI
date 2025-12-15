using Microsoft.AspNetCore.Mvc;

namespace Danciu_Radu_Lab1_BAMI.Controllers
{
    public class DanciuRaduController : Controller
    {
        public string Index()
        {
            return "Bine ai venit in aplicatia ASP.NET MVC!";
        }

        public string Salut()
        {
            return "Salut!";
        }


        public string MesajPersonalizat(string nume, int varsta)
        {
            return $"Salut {nume}! Ai {varsta} ani.";
        }
    }
}
