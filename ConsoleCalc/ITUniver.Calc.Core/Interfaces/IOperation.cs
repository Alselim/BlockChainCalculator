using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.Calc.Core.Interfaces
{
    public interface IOperation
    {
        //int argCount { get; }
        string Name { get; }
        double Exec(double[] args);
    }
}
