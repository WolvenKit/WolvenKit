using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CLocalizedString : CVariable
    {
        public CLocalizedString(CR2WFile cr2w)
            : base(cr2w)
        {
            if (cr2w != null)
            {
                cr2w.LocalizedStrings.Add(this);
            }
        }

        public uint val { get; set; }


        [DataMember]
        public string Text
        {
            get
            {
                var text = cr2w.GetLocalizedString(val);
                if (text != null)
                    return text;
                return val.ToString();
            }
            private set { }     //vl: dummy setter for serialization; in xml it's always number bc LocalizedSource is not avail
        }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is uint)
            {
                this.val = (uint) val;
            }
            else if (val is int)
            {
                this.val = (uint) (int) val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CLocalizedString(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CLocalizedString) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "val");
            return editor;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}