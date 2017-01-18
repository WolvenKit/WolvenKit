using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Types
{
    public class CDateTime : CVariable
    {
        public UInt64 val;

        public CDateTime(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            val = file.ReadUInt64();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is UInt64)
            {
                val = (UInt64)val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CDateTime(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CDateTime)base.Copy(context);
            var.val = val;
            return var;
        }
    }
}
