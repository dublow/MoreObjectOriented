using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.CompositePattern;
using Main.StatePattern;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var painters = new ProportionalPainter[5];
            painters[0] = new ProportionalPainter{ TimePerSqMeter = TimeSpan.FromHours(1), DollarsPerHour = 10};
            painters[1] = new ProportionalPainter { TimePerSqMeter = TimeSpan.FromHours(2), DollarsPerHour = 8 };
            painters[2] = new ProportionalPainter { TimePerSqMeter = TimeSpan.FromHours(3), DollarsPerHour = 6 };
            painters[3] = new ProportionalPainter { TimePerSqMeter = TimeSpan.FromHours(4), DollarsPerHour = 4 };
            painters[4] = new ProportionalPainter { TimePerSqMeter = TimeSpan.FromHours(5), DollarsPerHour = 2 };

            var painter = CompositePainterFactories
                .CreateCheapestSelector(painters)
                .EstimateCompensation(34);
        }
    }
}
