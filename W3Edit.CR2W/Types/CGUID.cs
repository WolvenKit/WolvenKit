using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.CR2W.Types
{
    public class CGUID : CVariable
    {
        public byte[] guid;

        public string GuidString { 
            get { return new Guid(guid).ToString(); }
            set { 
                Guid g;
                if(Guid.TryParse(value, out g)) {
                    guid = g.ToByteArray();
                }
            }
        }

        public CGUID(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            guid = file.ReadBytes(16);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(guid);
        }

        public override CVariable SetValue(object val)
        {
            if (val is byte[])
            {
                guid = (byte[])val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CGUID(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CGUID)base.Copy(context);
            var.guid = guid;
            return var;
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            var editor = new System.Windows.Forms.TextBox();
            editor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            editor.DataBindings.Add("Text", this, "GuidString");
            return editor;
        }

        public override string ToString()
        {
            Guid g = new Guid(guid);

            return g.ToString();
        }
    }
}
