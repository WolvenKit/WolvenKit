using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.RED3;

namespace WolvenKit.RED3.CR2W.Reflection
{
    public interface IRed3EngineFile : IWolvenkitFile
    {
        public List<ILocalizedString> LocalizedStrings { get; }

        public int GetStringIndex(string name, bool addnew = false);
        public string GetLocalizedString(uint val);

        public IEditableVariable ReadVariable(BinaryReader file, IEditableVariable parent);
        public int GetLastChildrenIndexRecursive(ICR2WExport chunk);
    }
}
