using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    public class CFlags : CVariable
    {
        public List<CName> flags = new List<CName>();

        public CFlags(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            while (true)
            {
                var val = file.ReadUInt16();
                if (val == 0)
                    break;
                flags.Add(new CName(cr2w) { Value = cr2w.strings[val].str });
            }
        }

        public override void Write(BinaryWriter file)
        {
            for (int i = 0; i < flags.Count; i++)
            {
                flags[i].Write(file);
            }
            file.Write((UInt16)0);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string[])
            {
                foreach(var flag in (string[])val)
                {
                    flags.Add(new CName(cr2w) { Value = flag });
                }
            }
            else if (val is string)
            {
                flags.Add(new CName(cr2w) { Value = (string)val });
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFlags(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFlags)base.Copy(context);

            foreach (var tag in flags)
            {
                var.flags.Add((CName)tag.Copy(context));
            }
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return flags.Cast<IEditableVariable>().ToList();
        }

        public override string ToString()
        {
            return "";
        }
    }
}
