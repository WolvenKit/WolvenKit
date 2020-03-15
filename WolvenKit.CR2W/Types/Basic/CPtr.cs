using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CPtr : CVariable
    {
        public int val;

        public CPtr(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        [DataMember(EmitDefaultValue = false)]
        public int ChunkIndex
        {
            get { return val - 1; }
            set { val = value + 1; }
        }

        public string PtrTargetType
        {
            get
            {
                if (val == 0)
                    return "";

                if (ChunkIndex < 0 || ChunkIndex >= cr2w.chunks.Count)
                    return "Invalid Ptr";

                return cr2w.chunks[ChunkIndex].Type;
            }
        }

        public CR2WExportWrapper PtrTarget
        {
            get
            {
                if (val == 0)
                    return null;

                if (ChunkIndex < 0 || ChunkIndex >= cr2w.chunks.Count)
                    return null;

                return cr2w.chunks[ChunkIndex];
            }

            set
            {
                if (value != null)
                {
                    val = value.ChunkIndex + 1;
                }
                else
                {
                    val = 0;
                }
            }
        }

        public override void Read(BinaryReader file, uint size)
        {
            val = file.ReadInt32();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is int)
            {
                this.val = (int) val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CPtr(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CPtr) base.Copy(context);
            context.ptrs.Add(var);
            var.val = val;
            return var;
        }

        public override Control GetEditor()
        {
            var editor = new ComboBox();
            editor.Items.Add(new PtrComboItem {Text = "", Value = 0});

            for (var i = 0; i < cr2w.chunks.Count; i++)
            {
                editor.Items.Add(new PtrComboItem {Text = cr2w.chunks[i].Type + " #" + (i + 1), Value = i + 1});
            }

            editor.SelectedIndexChanged += delegate(object sender, EventArgs e)
            {
                var item = (PtrComboItem) ((ComboBox) sender).SelectedItem;
                if (item != null)
                {
                    ChunkIndex = item.Value - 1;
                }
            };

            var selIndex = ChunkIndex + 1;
            if (selIndex < editor.Items.Count && selIndex >= 0)
            {
                editor.SelectedIndex = selIndex;
            }
            return editor;
        }

        public override string ToString()
        {
            return PtrTargetType + " #" + (ChunkIndex + 1);
        }

        internal class PtrComboItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
                xw.WriteElementString("PtrTargetType", this.PtrTargetType);
                xw.WriteElementString("Target", this.ToString());
                ser.WriteEndObject(xw);
            }
        }
    }
}