using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    public class SubOperation : IOperation
    {
        public int argCount
        {
            get { return 2; }
        }

        public string Name => "sub";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x - y);
        }
    }
}
