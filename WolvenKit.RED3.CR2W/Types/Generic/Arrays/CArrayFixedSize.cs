using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

using System.Linq;
using WolvenKit.RED3.CR2W.Reflection;
using System.ComponentModel;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]

    public class CArrayFixedSize<T> : CArray<T> where T : CVariable
    {
        public CArrayFixedSize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override string REDType
        {
            get
            {
                return BuildTypeName(Elementtype, Flags.AsEnumerable().GetEnumerator());
            }
        }

        private string BuildTypeName(string elementtype, IEnumerator<int> flags)
        {
            var v1 = flags.MoveNext() ? flags.Current : 0;
            return $"[{v1}]{Elementtype}";
        }

    }
}