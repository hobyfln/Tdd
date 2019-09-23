
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class YipYop
    {
        public string generate(int NumMin, int NumMax)
        {
            string resultat = "";

            resultat = EvaluateNumbers(NumMin, NumMax, resultat);

            return resultat;

        }

        public string EvaluateNumbers(int NumMin, int NumMax, string result)
        {

            while (NumMin <= NumMax)
            {
                result += DefineNumber(NumMin);
                NumMin++;
            }

            return result;

        }

        private string DefineNumber(int number)
        {
            if (number % 15 == 0)
            {
                return "yipyop";
            }
            if (number % 3 == 0)
            {
                return "yop";
            }
            if (number % 5 == 0)
            {
                return "yip";
            }
            return number.ToString();
        }



    }
}
