using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odd
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Enter your limit number");
            int limit = int.Parse(Console.ReadLine());
            int OddNumbers = 0;
            int notOddNumbers = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0) {

                OddNumbers++;
                }
                else
                {
                    notOddNumbers++;
                }
            }
            Console.WriteLine(OddNumbers);
            Console.WriteLine(notOddNumbers);


            Console.WriteLine("Enter your limit number");
            int limit1 = int.Parse(Console.ReadLine());
            int OddNumbers1 = 0;
            int notOddNumbers1 = 0;
            int i1 = 0;
            while (i1 < limit1) {
                if (i1 % 2 == 0)
                {

                    OddNumbers++;
                }
                else
                {
                    notOddNumbers++;
                }
                i1++;
            }
        }
    }
}
