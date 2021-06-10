using Lab1.Logic;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public DateTime dateTime = new DateTime();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.fecha = DateTime.Now;

            return View();
        }

        public IActionResult TarjetaPresentacion()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Operations()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Operations( string num1, string num2, string? num3)
        {
            
            Operations op = new Operations();

            try
            {
                double n1 = Convert.ToDouble(num1);
                double n2 = Convert.ToDouble(num2);
                double n3 = Convert.ToDouble(num3);

                op.Operaciones(n1, n2, n3);

                ViewBag.operationsList = op.OperationsList();

            }
            catch (DivideByZeroException ex)
            {
                ViewBag.OpError = "No se puede dividir un numero entre 0, ingrese otros valores. " + ex.Message;
            }
            catch (ArithmeticException ex)
            {
                ViewBag.OpError = "Datos ingresados son nulos, ingrese valores validos. " + ex.Message;
            }
            catch(FormatException ex)
            {
                ViewBag.OpError = "Dato ingresado es un string, ingrese un dato numerico. " + ex.Message;
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateVehicle()
        {


            return View();
        }

        [HttpPost]
        public IActionResult CreateVehicle(string marca, string year, string color, string llantas, bool categoria)
        {
            Operations op = new Operations();
            Vehicle vehicle = new Vehicle();

            try
            {
                int anio = Convert.ToInt32(year);
                int tires = Convert.ToInt32(llantas);

               op.CreateVehicle(marca, anio, color, tires, categoria);

                ViewBag.Vehicles = op.VehiclesList();

            }
            catch(NullReferenceException ex)
            {
                ViewBag.VehinullError = "Ingrese todos los datos "+ ex.Message;
            }
            catch (FormatException ex)
            {
                ViewBag.Vehistr = "Debe de ingresar solamente numeros, error causado: " +ex.Message;
            }
            catch (ArithmeticException ex)
            {
                ViewBag.VehiError = ex.Message;
            }


            return View(vehicle);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
