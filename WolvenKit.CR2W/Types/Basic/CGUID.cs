using System;
using System.IO;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    public class CGUID : CVariable
    {
        public byte[] guid;

        public CGUID(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        public string GuidString
        {
            get { return new Guid(guid).ToString(); }
            set
            {
                Guid g;
                if (Guid.TryParse(value, out g))
                {
                    guid = g.ToByteArray();
                }
            }
        }

        public override void Read(BinaryReader file, uint size)
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
                guid = (byte[]) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CGUID(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CGUID) base.Copy(context);
            var.guid = guid;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.Margin = new Padding(3, 3, 3, 0);
            editor.DataBindings.Add("Text", this, "GuidString");
            return editor;
        }

        public override string ToString()
        {
            var g = new Guid(guid);

            return g.ToString();
        }
    }
}