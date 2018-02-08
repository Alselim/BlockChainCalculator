using ITUniver.Calc.Core.Interfaces;
using System;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    public class PowOperation : IOperation
    {
        public int argCount
        {
            get { return 2; }
        }

        public string Name => "pow";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => Math.Pow(x, y));
        }
    }
}
