using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            divide(5, 0);
           
        }
        public static void divide(int a, int b)
        {
            try { 
              var result = a / b;
        }
            catch(DivideByZeroException ex){ 
                Console.WriteLine("You Can not divide by zero");
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
