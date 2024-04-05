using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Calculate:IAdd,IDifference,IDivide,IMultiply
    {
        public float Add(float num1, float num2) => num1 + num2;
        public float Difference(float num1, float num2) => num1 - num2;
        public float Divide(float num1, float num2) => num1 / num2;
        public float Multiply(float num1, float num2) => num1 * num2;



    }
}
