using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CFlags : CVariable
    {
        [RED] public CCompressedBuffer<CName> flags { get; set; }

        public CFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            flags = new CCompressedBuffer<CName>(cr2w, this, nameof(flags));
        }

        public override void Read(BinaryReader file, uint size)
        {
            while (true)
            {
                var val = file.ReadUInt16();
                if (val == 0)
                    break;
                flags.Add(new CName(cr2w, flags, nameof(flags))
                { Value = cr2w.names[val].Str});
            }
        }

        public override void Write(BinaryWriter file)
        {
            for (var i = 0; i < flags.Count; i++)
            {
                flags[i].Write(file);
            }
            file.Write((ushort) 0);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string[])
            {
                foreach (var flag in (string[]) val)
                {
                    flags.Add(new CName(cr2w, flags, "") {Value = flag});
                }
            }
            else if (val is string)
            {
                flags.Add(new CName(cr2w, flags, "") {Value = (string) val});
            }

            return this;
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CFlags(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFlags) base.Copy(context);

            foreach (var tag in flags)
            {
                var.flags.Add((CName) tag.Copy(context));
            }
            return var;
        }

        public override bool CanRemoveVariable(IEditableVariable child)
        {
            //FIXME
            if (child is CVariable v)
            {
                //return flags.Contains(v);
            }

            return true;
        }

        public override bool CanAddVariable(IEditableVariable newvar)
        {
            return newvar == null || newvar is CName;
        }

        public override void AddVariable(CVariable v)
        {
            if (v is CName v2)
            {
                flags.Add(v2);
            }

        }

        public override bool RemoveVariable(IEditableVariable child)
        {
            if (child is CName v)
            {
                flags.Remove(v);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "";
        }
    }
}