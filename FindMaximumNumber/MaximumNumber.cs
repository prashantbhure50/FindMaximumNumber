using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
   public class MaximumNumber
    {
        public static int Maximum(int firstNumber,int secondtNumber,int thirdtNumber)
        {
           
                if (firstNumber.CompareTo(secondtNumber) > 0 && firstNumber.CompareTo(thirdtNumber) > 0)
                {
                    return firstNumber;
                }
                else if (secondtNumber.CompareTo(firstNumber) > 0 && secondtNumber.CompareTo(thirdtNumber) > 0)
                {
                    return secondtNumber;
                }
                else if (thirdtNumber.CompareTo(secondtNumber) > 0 && thirdtNumber.CompareTo(firstNumber) > 0)
                {
                    return thirdtNumber;
                }
                throw new Exception("firstNumber,secondNumber,ThirdNumber are same");
            
        }
        public static float Maximum(float firstNumber, float secondtNumber, float thirdtNumber)
        {

            if (firstNumber.CompareTo(secondtNumber) > 0 && firstNumber.CompareTo(thirdtNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondtNumber.CompareTo(firstNumber) > 0 && secondtNumber.CompareTo(thirdtNumber) > 0)
            {
                return secondtNumber;
            }
            else if (thirdtNumber.CompareTo(secondtNumber) > 0 && thirdtNumber.CompareTo(firstNumber) > 0)
            {
                return thirdtNumber;
            }
            throw new Exception("firstNumber,secondNumber,ThirdNumber are same");

        }
        public static string Maximum(string firstNumber, string secondtNumber, string thirdtNumber)
        {

            if (firstNumber.CompareTo(secondtNumber) > 0 && firstNumber.CompareTo(thirdtNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondtNumber.CompareTo(firstNumber) > 0 && secondtNumber.CompareTo(thirdtNumber) > 0)
            {
                return secondtNumber;
            }
            else if (thirdtNumber.CompareTo(secondtNumber) > 0 && thirdtNumber.CompareTo(firstNumber) > 0)
            {
                return thirdtNumber;
            }
            throw new Exception("firstNumber,secondNumber,ThirdNumber are same");

        }
    }
}
