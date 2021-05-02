using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED3.CR2W.Reflection
{
    public interface IRed3EngineFile : IWolvenkitFile
    {
        public int GetStringIndex(string name, bool addnew = false);

        public IEditableVariable ReadVariable(BinaryReader file, IEditableVariable parent);
    }
}
