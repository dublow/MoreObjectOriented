using System.Collections.Generic;
using System.Linq;

namespace Main.CompositePattern
{
    class Painters
    {
        private IEnumerable<IPainter> ContainedPainters { get; }

        public Painters(IEnumerable<IPainter> containedPainters)
        {
            ContainedPainters = containedPainters.ToList();
        }

        public Painters GetAvailable() =>
            new Painters(this.ContainedPainters.Where(painter => painter.IsAvailable));

        public IPainter GetCheapestOne(double sqMeters) =>
            this.ContainedPainters.WithMinimun(painter => painter.EstimateCompensation(sqMeters));

        public IPainter GetFastestOne(double sqMeters) =>
            this.ContainedPainters.WithMinimun(painter => painter.EstimateTimeToPaint(sqMeters));
    }
}
