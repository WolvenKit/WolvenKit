using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    public class CName : CVariable
    {
        public CName(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort val
        {
            get { return (ushort) cr2w.GetStringIndex(Value, true); }
            set { Value = cr2w.strings[value].str; }
        }

        public string Value { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadUInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                Value = (string) val;
            }
            else if (val is ushort)
            {
                this.val = (ushort) val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CName(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CName) base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override Control GetEditor()
        {
            var enumtypes = typeof(Enums).GetNestedTypes();
            bool found = false;
            foreach (var item in enumtypes)
            {
                if(item.Name == this.Type)
                {
                    ComboBox cb = new ComboBox();
                    cb.Items.AddRange(item.GetEnumNames());
                    cb.SelectedValue = this.Type;
                    cb.SelectedValueChanged += HandleEnumPick;
                    return cb;
                }
            }
            var editor = new TextBox();
            editor.DataBindings.Add("Text", this, "Value");
            return editor;
        }

        private void HandleEnumPick(object sender, System.EventArgs e)
        {
            SetValue((sender as ComboBox).SelectedItem);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}