using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.App.Model
{
    public class Cp77Project : Project
    {
        public Cp77Project(string location) : base(location)
        {

        }

        private Task initializeTask;


        public override bool IsInitialized => initializeTask?.Status == TaskStatus.RanToCompletion;

        public override async Task Initialize() {}
        public override void Check() {}

        public override string ToString()
        {
            //TODO: serialize?
            throw new NotImplementedException();
        }
    }
}
