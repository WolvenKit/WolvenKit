using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    public interface IPtrAccessor
    {
        CR2WExportWrapper Reference { get; set; }
    }

    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta()]
    public class CPtr<T> : CVariable, IPtrAccessor where T : CVariable
    {

        public CPtr(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties
        public CR2WExportWrapper Reference { get; set; }
        #endregion

        #region Methods
        public string GetPtrTargetType()
        {
            try
            {
                if (Reference == null)
                    return "NULL";
                else
                    return Reference.REDType;
            }
            catch (Exception ex)
            {
                throw new InvalidPtrException(ex.Message);
            }
        }

        /// <summary>
        /// Reads an int from the stream and stores a reference to a chunk.
        /// A value of 0 means a null reference, all other chunk indeces are shifted by 1.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file, uint size)
        {
            var val = file.ReadInt32();

            try
            {
                if (val == 0)
                    Reference = null;
                else
                    Reference = cr2w.chunks[val - 1];
            }
            catch (Exception ex)
            {
                throw new InvalidPtrException(ex.Message);
            }
        }

        public override void Write(BinaryWriter file)
        {
            int val = 0;
            if (Reference != null)
                val = Reference.ChunkIndex + 1;

            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is CR2WExportWrapper)
            {
                this.Reference = (CR2WExportWrapper) val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CPtr<T>(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = (CPtr<CVariable>) base.Copy(context);
            
            context.ptrs.Add(copy);

            copy.Reference = this.Reference ?? this.Reference.CopyChunk(context);

            return copy;
        }

        public override Control GetEditor()
        {
            var editor = new ComboBox();
            editor.Items.Add(new PtrComboItem {Text = "", Value = null});

            foreach (var chunk in cr2w.chunks)
            {
                editor.Items.Add(new PtrComboItem
                {
                    Text = $"{chunk.REDType} #{chunk.ChunkIndex}", //real index
                    Value = chunk
                }
                );
            }

            editor.SelectedIndexChanged += delegate(object sender, EventArgs e)
            {
                var ptrcomboitem = (PtrComboItem) ((ComboBox) sender).SelectedItem;
                if (ptrcomboitem != null)
                {
                    Reference = ptrcomboitem.Value;
                }
            };

            var selIndex = Reference == null ? 0 : Reference.ChunkIndex + 1;
            if (selIndex < editor.Items.Count && selIndex >= 0)
            {
                editor.SelectedIndex = selIndex;
            }
            return editor;
        }

        public override string ToString()
        {
            if (Reference == null)
                return "NULL";
            else
                return Reference.REDType + " #" + (Reference.ChunkIndex);
        }

        public override void SerializeToXml(XmlWriter xw)
        {
            DataContractSerializer ser = new DataContractSerializer(this.GetType());
            using (var ms = new MemoryStream())
            {
                ser.WriteStartObject(xw, this);
                ser.WriteObjectContent(xw, this);
                xw.WriteElementString("PtrTargetType", this.GetPtrTargetType());
                xw.WriteElementString("Target", this.ToString());
                ser.WriteEndObject(xw);
            }
        }
        #endregion
    }

    public class PtrComboItem
    {
        public CR2WExportWrapper Value { get; set; }
        public string Text { get; set; }

        public override string ToString() => Text;
    }
}