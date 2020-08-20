using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Linq;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CName : CVariable
    {
        
        public CName(CR2WFile cr2w) : base(cr2w)
        {
            Type = typeof(CName).Name;
        }

        #region Properties
        [DataMember]
        public string Value { get; set; }
        public bool IsEnum { get; set; }
        #endregion


        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            SetValueInternal(file.ReadUInt16());
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            ushort val = 0;

            try
            {
                var nw = cr2w.names.First(_ => _.Str == Value);
                val = (ushort)cr2w.names.IndexOf(nw);
            }
            catch (Exception)
            {
            }

            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                Value = (string)val;
            }

            return this;
        }

        private void SetValueInternal(ushort val)
        {
            Value = cr2w.names[val].Str;
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
            editor.DataBindings.Add("Text", this, nameof(Value));
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
        #endregion

    }
}