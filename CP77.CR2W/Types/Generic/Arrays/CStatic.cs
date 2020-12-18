using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

using System.Linq;
using WolvenKit.CR2W.Reflection;
using System.ComponentModel;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]

    public class CStatic<T> : CArray<T> where T : CVariable
    {
        public CStatic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override string REDType
        {
            get
            {
                return Elementtype;
                //return BuildTypeName(Elementtype, Flags.AsEnumerable().GetEnumerator());
            }
        }

        private string BuildTypeName(string elementtype, IEnumerator<int> flags)
        {
            var v1 = flags.MoveNext() ? flags.Current : 0;
            return $"static:{v1},{elementtype}";
        }

    }
}