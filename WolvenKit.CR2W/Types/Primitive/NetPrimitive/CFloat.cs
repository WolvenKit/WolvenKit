using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;


namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CFloat : CVariable
    {
        public CFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        [DataMember]
        public float val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadSingle();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case float o:
                    this.val = o;
                    break;
                case CFloat cvar:
                    this.val = cvar.val;
                    break;
            }

            return this;
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CFloat(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFloat) base.Copy(context);
            var.val = val;
            return var;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}