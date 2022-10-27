using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uuygulama6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Derece Değerini Giriniz: ");
            double derece = Convert.ToDouble(Console.ReadLine());
            double radyan = derece * Math.PI / 180;
            double grad = (derece / 400) * 360;
            Console.WriteLine("{0} Derece = {1} Radyan = {2} Grad", derece, radyan, grad);



        }
    }
}
