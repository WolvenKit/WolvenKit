using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using WolvenKit.CR2W.Reflection;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CArray<T> : CArrayBase<T> where T : CVariable
    {

        public CArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size, (int)file.ReadUInt32());
        }


        public override void Write(BinaryWriter file)
        {
            CUInt32 count = new CUInt32(cr2w, null, "")
            {
                val = (uint)Elements.Count
            };
            count.Write(file);

            base.Write(file);
        }

        
    }
}