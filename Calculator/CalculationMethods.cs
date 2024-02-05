using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class CalculationMethods
    {
        
        //Additional Method
        public static int AddingMethod(int[] ints )
        {
            if (ints.Length == 0 ) return 0;
            var result = 0;
            foreach (var numer in ints)
            {
                result += numer;
            }
            return result;
        }

        public static double AddingMethod(double[] ints)
        {
            if (ints.Length == 0) return 0;
            var result = 0.0;
            foreach (var numer in ints)
            {
          
                result += numer;
            }
            return result;
        }
        public static float AddingMethod()
        {

        }
        public static decimal AddingMethod()
        {

        }
    }
}
