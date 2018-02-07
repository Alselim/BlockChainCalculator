using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace Google.Calc.Finance
{
    public class CreditOperation : IOperation
    {
        public int argCount
        {
            get { return 2; }
        }

        public string Name => "credit";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => (x * 1.094) / y);
        }

    }
}
