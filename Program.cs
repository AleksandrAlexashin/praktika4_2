using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika4_2
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            int otr = 0;
            int pol = 0;
            int n;
            Console.WriteLine("Введите последовательность целых чисел.Окончанием последовательности служит 0");
            
            do
               
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 0) pol++;
                if (n < 0) otr++;
                          
                
            }
              

            while (n != 0) ;


            if (pol>otr)Console.WriteLine("Положительных чисел больше");
            else Console.WriteLine("Отрицательных чисел больше");
            Console.ReadKey();
        }
    }
    
    
}
