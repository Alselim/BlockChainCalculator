
using System.Linq;

namespace Google.Calc.Finance
{
    public class CreditOperation : ITUniver.Calc.Core.Interfaces.IOperation
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
