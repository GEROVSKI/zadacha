using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstMVC.Views
{
    internal class Display
    {
        public void Input() 
        {
            Console.Write("Dai mi izqdenata suma:");
            double suma=double.Parse(Console.ReadLine());
            Console.WriteLine("Procent=");
            double procent =double.Parse(Console.ReadLine());
        }
        public void Outout()
        {
            Console.WriteLine($"Obshtata suma e:{tipSum}");
            Console.WriteLine($"Obshtata suma e:{totalSum}");
        }
    }
}
