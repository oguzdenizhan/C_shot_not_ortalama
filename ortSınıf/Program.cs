using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ortSınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] dizi = new double[3, 3];

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine((i+1) + ". Öğrenci ");
                for (int j = 0; j < 2; j++)
                {
                   double temp = Convert.ToDouble(Console.ReadLine());
                    dizi[i, j] = temp;
                }

                dizi[i, 2] = ( 0.4 * dizi[i, 0] + 0.6 * dizi[i, 1]);
                Console.WriteLine("Ortalama: "+dizi[i, 2]);

                
            }
            Console.ReadLine();
        }
    }
}
