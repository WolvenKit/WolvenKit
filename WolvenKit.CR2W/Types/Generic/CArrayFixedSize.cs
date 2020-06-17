using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using WolvenKit.CR2W.Editors;
using System.Linq;
using WolvenKit.CR2W.Reflection;
using System.ComponentModel;

namespace WolvenKit.CR2W.Types
{
    public class CArrayFixedSize<T> : CArray<T> where T : CVariable
    {
        public CArrayFixedSize(CR2WFile cr2w) : base(cr2w) { }



        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);   
        }

    }
}