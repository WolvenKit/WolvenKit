using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CName : CVariable
    {
       

        public CName(CR2WFile cr2w) : base(cr2w)
        {
            Type = typeof(CName).Name;
        }

        private ushort _val;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort Val
        {
            get
            {
                //return (ushort)cr2w.GetStringIndex(Value, true);
                return _val;
            }
            set
            {
                if (value > cr2w.names.Count)
                    value = 0;
                _val = value;
                //Value = cr2w.names[value].Str;
            }
        }

        [DataMember]
        public string Value
        {
            get
            {
                return cr2w.names[Val].Str;
            }
            set
            {
                Val = (ushort)cr2w.GetStringIndex(value, true);
            }
        }


        public override void Read(BinaryReader file, uint size)
        {
            Val = file.ReadUInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(Val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                Value = (string)val;
            }
            else if (val is ushort)
            {
                this.Val = (ushort)val;
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CName(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CName)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override Control GetEditor()
        {
            var enumtypes = typeof(Enums).GetNestedTypes();
            foreach (var item in enumtypes)
            {
                if (item.Name == this.Type)
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