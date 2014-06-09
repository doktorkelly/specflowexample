using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specflow01
{
    public class Calculator
    {
        IList<int> Numbers { get; set; }

        public Calculator()
        {
            Numbers = new List<int>();
        }

        public void Push(int number)
        {
            Numbers.Add(number);
        }

        public void Clear()
        {
            Numbers = new List<int>();
        }

        public int Add()
        {
            int sum = 0;
            foreach (int number in Numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
    }
}
