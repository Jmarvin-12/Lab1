using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Logic
{
    public class Operations
    {
        public static List<double> operationsList { get; set; }

        public static List<Vehicle> vehicleList = new List<Vehicle>();

        public List<double> OperationsList()
        {

            return operationsList;
        }

        public List<Vehicle> VehiclesList()
        {
            return vehicleList;
        }

        public List<double> Operaciones(double n1, double n2, double? n3)
        {

            operationsList = new List<double>();

            try
            {
                double suma = n1 + n2;
                operationsList.Add(suma);
                double resta = n1 - n2;
                operationsList.Add(resta);
                double multi = n1 * n2;
                operationsList.Add(multi);

                if (n1 == 0 && n2 == 0 && n3 ==0)
                {

                    throw new ArithmeticException();

                }else if (n2 == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    double divi = n1 / n2;
                    operationsList.Add(divi);
                }


                double potencia = Math.Pow(suma, (double)n3);
                operationsList.Add(potencia);
                double radica = Math.Sqrt(suma);
                operationsList.Add(radica);

            }
            catch (FormatException)
            {
                throw;
            }
                

            return operationsList;
        }

        public List<Vehicle> CreateVehicle(string Marca, int year, string color, int llantas, bool categoria)
        {
            
            try
            {
                string category;
                if(categoria)
                {
                    category = "Sedan";
                }
                else
                {
                    category = "Pickup";
                }

                vehicleList.Add(new Vehicle(Marca, year, color, llantas, category));
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
            catch (ArithmeticException) {
                throw new ArithmeticException();
            }


            return vehicleList;
        }

    }

    public class Vehicle
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public int llantas { get; set; }
        public string category { get; set; }
        public DateTime EntryDate { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string Marca, int year, string color, int llantas, string category)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Marca = Marca;
            this.year = (int)year;
            this.color = color;
            this.llantas = llantas;
            this.category = category;
            this.EntryDate = DateTime.Now;
        }


    }
}
