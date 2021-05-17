using System;

namespace WolvenKit.Common.Services
{
    public class MockProgressService : IProgress<double>
    {
        public void Report(double value)
        {
            // do nothing
        }
    }
}
