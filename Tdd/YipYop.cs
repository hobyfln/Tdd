using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    public class YipYop
    {
        public string generate(int NumMin, int NumMax)
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
                (NumMin % 15 == 0)
            {
                result += "yipyop";
            }

            else if
               (NumMin % 3 == 0)
            {
                result += "yop";
            }
            else if (NumMin % 5 == 0)
            {
                result += "yip";
            }

            else
            {
                result += NumMin;
            }

            if(NumMin < NumMax)
                if(NumMax % 15 == 0)
                {
                    result += "yipyop";
                }

                else if
                   (NumMax % 3 == 0)
                {
                    result += "yop";
                }
                else if (NumMax % 5 == 0)
                {
                    result += "yip";
                }

                else
                {
                    result += NumMax;
                }
            
            return result ;
        }
    }
}
