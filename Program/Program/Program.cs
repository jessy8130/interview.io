using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }

        public int[] Question1(int[] nums, int target)
        {
            return new int[2];
        }


        public bool Question6(int n)
        {
            //先判斷n
            if (n < 1) return false;
            while(n > 1)
            {
                if(n % 2 ==  0)
                {
                    n = n / 2;
                }
                else if(n % 3 == 0)
                {
                    n = n / 3;
                }
                else if(n%5 == 0)
                {
                    n = n / 5;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }


        public bool Question7(int num)
        {
            if(num <= 1) return false;
            while(num > 1)
            {
                if(num % 4 == 0)
                {
                    num = num / 4;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

    }
}
