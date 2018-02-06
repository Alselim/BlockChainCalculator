using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    public class MulOperation : IOperation
    {
        //public int argCount
        //{
        //    get { return 2; }
        //}

        public string Name => "mul";

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => x * y);
        }
    }
}
