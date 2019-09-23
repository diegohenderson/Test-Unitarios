using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnitarios.Services;
namespace TestUnitarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("salario bruto anual: ");
            var grossStr = Console.ReadLine();
            if (decimal.TryParse(grossStr, out decimal gross))
            {
                Console.WriteLine("no es un valor valido, pulsa enter para salir: ");
                Console.ReadLine();
                return;
            }
            var taxService = new TaxService();
            Console.WriteLine($"vas a pagar: {taxService.GetTax(gross)}.");
            Console.ReadLine();
        }
    }
}
