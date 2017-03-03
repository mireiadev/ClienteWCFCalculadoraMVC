using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClienteWCFCalculadora.ServiceCalculadora;
using System.ServiceModel;

namespace ClienteWCFCalculadora.Controllers
{
    public class CalculadoraController : Controller
    {
        ServicioCalculadoraClient client;

        public CalculadoraController()
        {
            client = new ServicioCalculadoraClient();
        }

        // GET: Calculadora
        public ActionResult Index()
        {
            return View();
        }
      
        //Método Ajax
        public ActionResult Division(string num1, string num2)
        {
            try
            {
                float n1 = float.Parse(num1);
                float n2 = float.Parse(num2);
                ViewBag.Resultado= client.Division(n1, n2);
                return View("_parcialresultado");
            }
            catch (FaultException<ExcepcionPersonalizada> ex)
            {
                String msn = "ERROR: "+ex.Detail.DetailError + " Código:" + ex.Detail.InternalCodeError + "" + ex.Detail;
                ViewBag.Resultado = msn;
                ViewBag.Error = true;
                return View("_parcialresultado");
            }

        }
    }
}