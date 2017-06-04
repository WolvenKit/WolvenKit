using System.IO;

namespace WolvenKit.CR2W.Types
{
    public class CDateTime : CVariable
    {
        public ulong val;

        public CDateTime(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt64();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            val = val as ulong?;

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CDateTime(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CDateTime) base.Copy(context);
            var.val = val;
            return var;
        }
    }
}