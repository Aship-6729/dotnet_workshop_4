using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number += 10;
        }

        public void GetFullName(out string fullName)
        {
            fullName = "John Doe";
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
