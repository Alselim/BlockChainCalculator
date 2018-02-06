using System;

namespace ITUniver.Calc.Core.Interfaces
{
    public interface IOperation
    {
        int argCount { get; }
        
        string Name { get; }

        double Exec(double[] args);
    }
}
