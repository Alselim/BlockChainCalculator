using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    public class SumOperation : SuperOperation
    {
        public override string Description => "Арифметическое действие, посредством которого из двух или нескольких чисел получают новое, содержащее столько единиц, сколько было во всех данных числах вместе.";

        public override string Name => "sum";

        public override double Exec(double[] args)
        {
            return args.Sum();
        }
    }
}
