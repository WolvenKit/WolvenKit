using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W.Reflection
{
    public interface IRed4EngineFile : IWolvenkitFile
    {
        public bool CreatePropertyOnAccess { get; set; }
        public List<string> UnknownVars { get; set; }


        public int GetStringIndex(string name, bool addnew = false);

        public IEditableVariable ReadVariable(BinaryReader file, IEditableVariable parent);
    }
}
