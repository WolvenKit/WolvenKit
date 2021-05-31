using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]
    public class CFloat : CVariable, IREDPrimitive<float>
    {
        public CFloat()
        {

        }
        public CFloat(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        [DataMember]
        public float Value { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Value = file.ReadSingle();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(Value);
        }

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                float o => o,
                CFloat cvar => cvar.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CFloat) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
