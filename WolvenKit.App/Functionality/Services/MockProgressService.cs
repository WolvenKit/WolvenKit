using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Functionality.Services
{
    public class MockProgressService : IProgress<double>
    {
        public void Report(double value)
        {
            // do nothing
        }
    }
}
