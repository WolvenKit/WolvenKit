using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CFloat : CVariable
    {
        public CFloat(CR2WFile cr2w)
            : base(cr2w)
        {
        }

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
            if (val is float)
            {
                this.val = (float) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFloat(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CFloat) base.Copy(context);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new TextBox();
            editor.Margin = new Padding(3, 3, 3, 0);
            editor.DataBindings.Add("Text", this, "val");
            //editor.Dock = System.Windows.Forms.DockStyle.Fill;
            //editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            return editor;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }
}