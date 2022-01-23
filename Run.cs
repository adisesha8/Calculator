using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Run
    {
        static void Main()
        {
            //args = Console.ReadLine();
            try
            {
                //
                CompareWith5();
            }
            catch (Exception ex)
            {
                //throw (ex);
                Console.WriteLine(ex);
            }

            //Console.ReadLine();

            try
            {
                ReRun();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void ReRun()
        {            
            //Console.WriteLine("Do you want to re-run? (Y/N) \n {0}", new NotImplementedException());
            Console.WriteLine("Do you want to re-run? (Y/N)");
            string a = Console.ReadLine();
            if (char.IsLetter(a[0])
                && ((char.IsUpper(a[0]) && a[0].Equals('Y'))
                || (char.IsLower(a[0]) && a[0].Equals('y')))
                )
            {
                //Console.WriteLine("char.IsLetter(a[0]) : {0} /n" +
                //    "(char.IsUpper(a[0]) : {1} /n" +
                //    "a[0].Equals(\"Y\") : {2} /n" +
                //    "(char.IsLower(a[0]) : {3} /n" +
                //    "a[0].Equals(\"y\") : {4}", char.IsLetter(a[0]), char.IsUpper(a[0]), a[0].Equals("Y"), char.IsLower(a[0]), a[0].Equals("y")
                //    );
                CompareWith5();
                ReRun();
            }
        }

        private static void CompareWith5()
        {            
            Console.WriteLine("Hello World!! Input a number .... ");
            String a = Console.ReadLine();
            if (Convert.ToInt32(a) == 5) //Error
            {
                Console.WriteLine("The Number entered is {0} and is equal to 5.", a);
            }
            else
            {
                Console.WriteLine("The Number is {0} and is not equal to 5.", a);
            }
        }

        private static void CompareWith5(string a)
        {
            Console.WriteLine("Hello World!! Input a number .... ");

            if (Convert.ToInt32(a) == 5) //Error
            {
                Console.WriteLine("The Number entered is {0} and is equal to 5.", a);
            }
            else
            {
                Console.WriteLine("The Number is {0} and is not equal to 5.", a);
            }
        }
    }
}
