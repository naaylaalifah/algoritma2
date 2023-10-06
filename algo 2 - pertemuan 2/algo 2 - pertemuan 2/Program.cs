using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo_2___pertemuan_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            int jumlah;
            Console.Write("Masukan banyak data :"); jumlah = int.Parse(Console.ReadLine());
            Console.WriteLine();

            ArrayList nama = new ArrayList();
            ArrayList nim = new ArrayList();
            ArrayList jurusan = new ArrayList();

            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine("Masukan date ke-{0}", (i + 1));
                Console.Write("Masukan data Nama : "); nama.Add(Console.ReadLine());
                Console.Write("Masukan data Nim : "); nim.Add(Console.ReadLine());
                Console.Write("Masukan data Jurusan : "); jurusan.Add(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Clear();

            Console.WriteLine("Data Mahasiswa");
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine("Nama :" + nama[i]);
                Console.WriteLine("Nim :" + nim[i]);
                Console.WriteLine("Jurusan :" + nim[i]);
                Console.WriteLine();
            }

            Console.ReadKey();

            */

            //foreach

            ArrayList nama = new ArrayList();
            nama.Add("john");
            nama.Add("lenon");
            nama.Add("jim");
            nama.Add("carey");

            foreach (string i in nama)
            {
                Console.WriteLine(i);
            }
        }
    }
}
