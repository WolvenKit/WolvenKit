using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta()]
    public class CString : CVariable, IREDPrimitive
    {
        private bool isWideChar;

        public CString()
        {
            
        }
        public CString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string val { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadLengthPrefixedString();
        }

        public override void Write(BinaryWriter file)
        {
            file.WriteLengthPrefixedString(val);
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case string s:
                    this.val = s;
                    break;
                case CString cvar:
                    this.val = cvar.val;
                    break;
            }

            return this;
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CString) base.Copy(context);
            var.val = val;
            var.isWideChar = isWideChar;
            return var;
        }



        public override string ToString()
        {
            return val;
        }
    }
}