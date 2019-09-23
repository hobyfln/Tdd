using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    public class YipYop
    {
        public string generate(int number)
        {
            string result = "";
            //if(number == 1)
            //   {
            //       result = number.ToString();      
            //   }
            //if(number == 2)
            //   {
            //       result = number.ToString();
            //   }
            //   if (number == 3)
            //   {
            //       result = "Yop";
            //   }
            if
                (number % 15 == 0)
            {
                result = "yipyop";
            }

            if
               (number % 3 == 0)
            {
                result = "yop";
            }
            else if (number % 5 == 0)
            {
                result = "yip";
            }

            else
            {
                result = number.ToString();
            }

            return result ;
        }
    }
}
