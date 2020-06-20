using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class EntityHandle : CVariable
    {
        public CUInt16 id;
        public CGUID guid;
        public CBytes unk1;

        public EntityHandle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            id = new CUInt16(cr2w, this, nameof(id));
            guid = new CGUID(cr2w, this, nameof(guid));
            unk1 = new CBytes(cr2w, this, nameof(unk1))
            { Bytes = Array.Empty<byte>() };
        }

        public override void Read(BinaryReader file, uint size)
        {
            id.Read(file, 2);
            guid.Read(file, 16);
            if (size - 18 > 0)
            {
                unk1.Read(file, size - 18);
            }
                
        }

        public override void Write(BinaryWriter file)
        {
            id.Write(file);
            guid.Write(file);
            unk1.Write(file);
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new EntityHandle(cr2w, parent, name);
        }

        public override string ToString()
        {
            return $"[{id.ToString()}]:{guid.ToString()}";
        }
    }
}