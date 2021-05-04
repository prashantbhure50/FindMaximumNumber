using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
   public class MaximumNumber<T> where T:IComparable
    {
        public T firstNumber, secondNumber, thirdNumber;
        public MaximumNumber(T firstNumber, T secondNumber, T thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;

        }
        public static  T Maximum (T firstNumber,T secondNumber,T thirdNumber)
        {
           
                if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                {
                    return firstNumber;
                }
                else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                {
                    return secondNumber;
                }
                else if (thirdNumber.CompareTo(secondNumber) > 0 && thirdNumber.CompareTo(firstNumber) > 0)
                {
                    return thirdNumber;
                }
                throw new Exception("firstNumber,secondNumber,ThirdNumber are same");
            
        }
        public T maxMethod()
        {
            T max = MaximumNumber<T>.Maximum(this.firstNumber,this.secondNumber,this.thirdNumber);
            
            return max;
           
        }
      
    }
}
