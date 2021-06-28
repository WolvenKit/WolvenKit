using System;
using System.Globalization;

namespace WolvenKit.Common.Services
{
    public class MockProgressService : IProgress<double>
    {
        public void Report(double percValue)
        {
            // do nothing
        }
    }

    public class PercentProgressService : IProgress<double>
    {
        private int _maxPercent;

        public PercentProgressService()
        {

        }

        public void Reset() => _maxPercent = 0;

        public void Report(double percValue)
        {
            var perc = (int)(percValue * 100);

            if (perc == 0)
            {
                Reset();
                return;
            }

            if (perc > _maxPercent)
            {
                _maxPercent = perc;
            }

            Console.Write("\r{0}%", _maxPercent.ToString(CultureInfo.InvariantCulture));

            if (perc == 100)
            {
                Console.WriteLine();
            }
        }
    }
}
