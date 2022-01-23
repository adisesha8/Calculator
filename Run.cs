using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Run
    {
        static void Main()
        {
            Console.WriteLine("Hello World!! Input a number .... ");
            //args = Console.ReadLine();
            try
            {
                String a = Console.ReadLine(); //Error
                if (Convert.ToInt32(a) == 5) //Error
                {
                    Console.WriteLine("The Number is {0}", a);
                }
            }
            catch (Exception ex)
            {
                //throw (ex);
                Console.WriteLine(ex);
            }

            //Console.ReadLine();

            try
            {
                String a = Console.ReadLine();
                ReRun(a[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void ReRun(char args)
        {
            Console.WriteLine("Do you want to re-run? (Y/N)" , new NotImplementedException());

        }
    }
}
