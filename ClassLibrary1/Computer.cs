using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer
{
    public interface Computer
    {
        string Name { get; }
        double Compute(params double[] values);
    }


}
