using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class CArray<T> : CArrayBase<T> where T : CVariable
    {

        public CArray(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size, (int)file.ReadUInt32());
        }


        public override void Write(BinaryWriter file)
        {
            file.Write((uint)Count);
            base.Write(file);
        }


    }
}
