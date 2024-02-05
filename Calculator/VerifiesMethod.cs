using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public class VerifiesMethod
    {
        private string _userinput;

        private readonly HashSet<char> mustContainValue = new HashSet<char>
                {
                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                    '*', '/', '+', '-'
                };

        private readonly HashSet<char> mustContainFirstValue = new HashSet<char>
                {
                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                     '+', '-'
                };
        private readonly HashSet<char> mustContainNumber = new HashSet<char>
                {
                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
                  
                };

        private readonly HashSet<char> mustContainOperations = new HashSet<char>
                {
                     '*', '/', '+', '-'

                };

        private readonly HashSet<char> mustContainFirstOperations = new HashSet<char>
                {
               
                     '+', '-'

                };
        public VerifiesMethod(string userinput)
        {
            _userinput = userinput;
            ExecuteMethod();
        }

        private void ExecuteMethod()
        {
            //Critirie Checking 
            bool IsValidValue = false;
            bool IsValidFomat = false;


            if (_userinput == null)
            {
                return;
            }
            else
            {
                _userinput.Trim();
                var CharArray = _userinput.ToCharArray();
                IsValidValue = IsContainValidValue(CharArray);
                if (IsValidValue)
                {
                    MessageBox.Show("Valid Value");
                    IsValidFomat = IsValidFormatsInput(CharArray);
                    if (IsValidFomat)
                    {
                        MessageBox.Show("Valid Format");
                    }
                    else
                    {
                        MessageBox.Show("InValid Format");
                    }
                }
                else
                {
                    MessageBox.Show("InValid Value");
                }

            }
        }
        //

        private bool IsContainValidValue(char[] chars)
        {
            if (chars == null)
            {
                return false;
            }
            else
            {
                foreach (char c in chars)
                {
                    if (!mustContainValue.Contains(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private bool IsValidFormatsInput(char[] chars)
        {
            if (chars == null || chars.Length == 0)
            {
                return false;
            }

   
            if (!mustContainFirstValue.Contains(chars[0]) || !mustContainFirstValue.Contains(chars[chars.Length - 1]))
            {
                return false;
            }

   
            for (int i = 1; i < chars.Length; i++)
            {
                if (mustContainOperations.Contains(chars[i - 1]) && mustContainOperations.Contains(chars[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IdentifyFirstDigit(char c)
        {

            if (mustContainFirstOperations.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
