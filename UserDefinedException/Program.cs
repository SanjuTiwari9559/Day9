using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                divide(5, 0);
            }
            catch (SelfDefineException ex)
            {
                Console.WriteLine(ex.Message);

            }

        }
        public static void divide(int a, int b)
        {
            try
            {
                var result = a / b;
            }
            catch (Exception e)
            {
                throw new SelfDefineException("You Can not Divided By Zero please Check", e);
            }
        }
    }
}
