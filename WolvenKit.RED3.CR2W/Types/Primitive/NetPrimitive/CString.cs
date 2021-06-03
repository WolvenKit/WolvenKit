using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using WolvenKit.RED3.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]
    public class CString : CVariable, IREDPrimitive<string>
    {
        private bool isWideChar;

        public CString()
        {

        }
        public CString(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string Value { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Value = file.ReadLengthPrefixedString();
        }

        public override void Write(BinaryWriter file)
        {
            file.WriteLengthPrefixedString(Value);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            this.Value = val switch
            {
                string s => s,
                CString cvar => cvar.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CString) base.Copy(context);
            var.Value = Value;
            var.isWideChar = isWideChar;
            return var;
        }



        public override string ToString()
        {
            return Value;
        }
    }
}
