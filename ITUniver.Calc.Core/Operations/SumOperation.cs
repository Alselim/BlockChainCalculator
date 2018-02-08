using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    public class SumOperation : IOperation
    {
        public int argCount
        {
            get { return 2; }
        }

        public string Name => "sum";

        public double Exec(double[] args)
        {
            return args.Sum();
        }
    }
}
