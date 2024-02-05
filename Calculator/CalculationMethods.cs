using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
#region Arithmetic Operations
    public class CalculationMethods
    {

        #region<Summation>
        //Additional Method
        public static int? SummationMethod(int[] numbers )
        {
            if (numbers == null || numbers.Length == 0) return null;
            var result = 0;
            foreach (var numer in numbers)
            {
                result += numer;
            }
            return result;
        }
        public static double? SummationMethod(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;
            var result = 0d;
            foreach (var numer in numbers)
            {
          
                result += numer;
            }
            return result;
        }
        public static float? SummationMethod(float[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;
            var result = 0f;
            foreach (var numer in numbers)
            {

                result += numer;
            }
            return result;
        }
        public static decimal? SummationMethod(decimal[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;
            var result = 0m;
            foreach (var numer in numbers)
            {

                result += numer;
            }
            return result;
        }
        public static long? SummationMethod(long[] numbers)
        {
            if (numbers.Length == 0) return 0;
            var result = 0L;
            foreach (var numer in numbers)
            {

                result += numer;
            }
            return result;
        }
        #endregion
        #region <SubtractionsArray>  
        public static int? SubtractionsMethodArray(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;

            var result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public static double? SubtractionsMethodArray(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;

            var result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        public static float? SubtractionsMethodArray(float[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;

            var result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        public static decimal? SubtractionsMethodArray(decimal[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;

            var result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        public static long? SubtractionsMethodArray(long[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return null;

            var result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }
        #endregion
        #region <Addition Methods>
        public int? AdditionArithmetic(int? number1 , int? number2)
        {
            return number1+number2;
        }
        public double? AdditionArithmetic(double? number1, double? number2)
        {
            return number1 + number2;
        }
        public long? AdditionArithmetic(long? number1, long? number2)
        {
            return number1 + number2;
        }
        public decimal? AdditionArithmetic(decimal? number1, decimal? number2)
        {
            return number1 + number2;
        }

        #endregion


    }
}
#endregion
