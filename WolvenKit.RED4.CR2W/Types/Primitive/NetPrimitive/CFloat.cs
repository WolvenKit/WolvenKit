using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace WolvenKit.RED4.CR2W.Types
{
    public class CFloat : CVariable, IREDIntegerType<float>
    {
        public CFloat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public float Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadSingle();

        public override void Write(BinaryWriter file) => file.Write(Value);

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
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

        public override string ToString() => Value.ToString();
    }
}
