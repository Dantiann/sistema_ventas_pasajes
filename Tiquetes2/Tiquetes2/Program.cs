using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiquetes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TIQUETE DE PASAJES");
            Console.WriteLine("********************");

            Console.WriteLine("Ingrese el origen de la ciudad: ");
            var origen = Console.ReadLine();

            Console.WriteLine("Ingrese el destino de la ciudad: ");
            var destino = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha dd/mm/yy: ");
            var fecha = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de tiquetes disponibles: ");
            var tiquets = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del tiquete: ");
            var precio = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del conductor: ");
            var choferName = Console.ReadLine();

            Console.WriteLine("Ingrese el Id del conductor: ");
            var choferId = Console.ReadLine(); 

            Console.WriteLine("Ingrese el número de identidicación del carro: ");
            var carNum = Console.ReadLine(); 

            Console.WriteLine("Ingrese la placa del carro: ");
            var placa = Console.ReadLine();

            for (int i = 0; i < tiquets; i++)
            {
                Console.WriteLine("Ingrese el nombre del viajero: ");
                var nombreViajero = Console.ReadLine();

                Console.WriteLine("Ingrese la identificación del viajero: ");
                var idViajero = Console.ReadLine();

                Console.WriteLine($"Nombre del viajero: {nombreViajero}. Identificación: {idViajero}");
                Console.WriteLine($"Nombre del chofer: {choferName}. Identificación: {choferId}. Carro N°: {carNum}. Placa: {placa}. Fecha: {fecha}. Precio: {precio}");
            }
            Console.ReadKey();
        }
    }
}