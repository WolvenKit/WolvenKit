using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]
    public class CFloat : CVariable, IREDPrimitive
    {
        public CFloat()
        {
            
        }
        public CFloat(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

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

        public override CVariable Copy(ICR2WCopyAction context)
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