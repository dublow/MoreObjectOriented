using System.Collections.Generic;
using System.Linq;

namespace Main.CompositePattern
{
    public static class PainterUtilities
    {
        public static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            return painters
                .Where(painter => painter.IsAvailable)
                .WithMinimun(p => p.EstimateCompensation(sqMeters));


        }
    }
}
