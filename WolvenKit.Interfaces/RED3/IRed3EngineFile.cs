using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.Interfaces.RED3
{
    public interface IRed3EngineFile : IWolvenkitFile
    {
        public bool CreatePropertyOnAccess { get; set; }

        public int GetStringIndex(string name, bool addnew = false);

        public IEditableVariable ReadVariable(BinaryReader file, IEditableVariable parent);
    }
}
