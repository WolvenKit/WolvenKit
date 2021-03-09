using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using CP77.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace CP77.CR2W.Types
{
    [REDMeta()]
    [Editor(typeof(ITextEditor<string>), typeof(IPropertyEditorBase))]
    public class CString : CVariable, IREDString
    {
        private bool _isWideChar;

        public CString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string Value { get; set; }

        public override void Read(BinaryReader file, uint size) => Value = file.ReadLengthPrefixedString();

        public override void Write(BinaryWriter file) => file.WriteLengthPrefixedString(Value);

        public override CVariable SetValue(object val)
        {
            this.Value = val switch
            {
                string s => s,
                CString cvar => cvar.Value,
                _ => this.Value
            };

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CString) base.Copy(context);
            var.Value = Value;
            var._isWideChar = _isWideChar;
            return var;
        }



        public override string ToString() => Value;
    }
}
