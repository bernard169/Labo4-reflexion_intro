using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using computer;
namespace Adder
{
    public class Adder : Computer
    {
        public string Name
        {
            get { return "Adder"; }
        }

        public double Compute(params double[] values)
        {
            double result = 0;
            Array.ForEach(values, value => result += value);
            return result;
        }
    }
}
