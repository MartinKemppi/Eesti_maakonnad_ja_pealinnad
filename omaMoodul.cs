using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alamprogrammid
{
    internal class Alamprogramm
    {
        public static double Keskmine(int k)
        {
            int[] numbers = new int[k];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"Sisesta number {i+1}");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;            
            }
            double arth = (double)sum / numbers.Length;

            return arth;
        }

        public static string Kassi_kalkulaator(int arv1,int arv2, char tehe)
        {            
            System.Data.DataTable table = new System.Data.DataTable();
            double j = Convert.ToDouble(table.Compute(arv1.ToString() + tehe.ToString() + arv2.ToString(), String.Empty));

            j = Math.Round(j, 0);
            string vastus = "";
            string nur = "nurr ";
            for (int i = 0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                vastus = vastus + nur;
            }
            return vastus;
            
        }

        public static void Stars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
                
            }
            Console.WriteLine();
        }

        public static void NStars(int k)
        {
            int[] stars = new int[k];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("{0} arv", i + 1);
                stars[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int num in stars)
            {
                Stars(num);
                Console.WriteLine();
            }
        }
    }
}
