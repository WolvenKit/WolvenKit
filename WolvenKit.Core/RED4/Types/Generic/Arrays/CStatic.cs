using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

using System.Linq;
using WolvenKit.RED4.CR2W.Reflection;
using System.ComponentModel;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]

    public class CStatic<T> : CArray<T> where T : CVariable
    {
        public CStatic(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override string REDType => REDReflection.GetREDTypeString(GetType(), Flags.ToArray());
    }
}
