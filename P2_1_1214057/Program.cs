using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tugas arithematic Operators Maylinda");
            Console.Write("Angka Pertama = ");
            int angka1 = int.Parse(Console.ReadLine());
            Console.Write("Angka Kedua = ");
            int angka2 = int.Parse(Console.ReadLine());

            double penjumlahan = angka1 + angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, penjumlahan);

            double pengurangan = angka1 - angka2;
            Console.WriteLine("{0} - {1} = {2}",angka1, angka2, pengurangan);

            double perkalian = angka1 * angka2;
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, perkalian);

            double pembagian = angka1 / angka2;
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, pembagian);

        }

    }
}
