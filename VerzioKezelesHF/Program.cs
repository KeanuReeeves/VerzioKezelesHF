using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg hogy mennyi számot szeretne felvenni: ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<int> szamok = new List<int>();
            string[] st;
            Console.WriteLine("Adjon meg {0} számot (szóközzel elválasztva): ",N);
            string szam = Console.ReadLine();
            for (int i = 0; i < N; i++)
            {
                st = szam.Split(' ');
                if (st.Length==N)
                {
                    szamok.Add(Convert.ToInt32(st[i]));
                }
                
            }
            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
