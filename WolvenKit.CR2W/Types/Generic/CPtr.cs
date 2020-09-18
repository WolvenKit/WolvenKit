using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    public interface IPtrAccessor
    {
        CR2WExportWrapper Reference { get; set; }
        string ReferenceType { get; }
        bool IsSerialized { get; set; }
    }

    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
    public class CPtr<T> : CVariable, IPtrAccessor where T : CVariable
    {
       

        public CPtr(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties

        public CR2WExportWrapper Reference { get; set; }
        public string ReferenceType => REDType.Split(':').Last();
        #endregion

        #region Methods
        public string GetPtrTargetType()
        {
            return ReferenceType;
            //try
            //{
            //    if (Reference == null)
            //        return "NULL";
            //    return Reference.REDType;
            //}
            //catch (Exception ex)
            //{
            //    throw new InvalidPtrException(ex.Message);
            //}
        }

        /// <summary>
        /// Reads an int from the stream and stores a reference to a chunk.
        /// A value of 0 means a null reference, all other chunk indeces are shifted by 1.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file, uint size)
        {
            SetValueInternal(file.ReadInt32());
        }

        private void SetValueInternal(int val)
        {
            try
            {
                Reference = val == 0 ? null : cr2w.chunks[val - 1];
            }
            catch (Exception ex)
            {
                throw new InvalidPtrException(ex.Message);
            }

            // Try reparenting on virtual mountpoint
            if (Reference != null)
            {
                Reference.Referrers.Add(this); //Populate the reverse-lookup

                if (!Reference.IsVirtuallyMounted)
                {
                    Reference.VirtualParentChunkIndex = GetVarChunkIndex();
                }
                else switch (REDName)
                {
                    case "parent" when !cr2w.chunks[GetVarChunkIndex()].IsVirtuallyMounted:
                        cr2w.chunks[GetVarChunkIndex()].VirtualParentChunkIndex = Reference.ChunkIndex;
                        break;
                    case "child" when Reference.IsVirtuallyMounted:
                        //remount, needed for chardattachment
                        Reference.IsVirtuallyMounted = false;
                        Reference.VirtualParentChunkIndex = GetVarChunkIndex();
                        break;
                }
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
            switch (val)
            {
                case CR2WExportWrapper wrapper:
                    Reference = wrapper;
                    break;
                case IPtrAccessor cval:
                    Reference = cval.Reference;
                    break;
            }

            return this;
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = (CPtr<T>)base.Copy(context);

            if (Reference != null)
            {
                CR2WExportWrapper newref = context.DestinationFile.TryLookupReference(copy, Reference);
                if (newref != null)
                    copy.SetValue(newref);
            }
            

            return copy;
        }

        public override Control GetEditor()
        {
            var editor = new ComboBox();
            editor.Items.Add(new PtrComboItem {Text = "", Value = null});

            var availableChunks = CR2WManager.GetAvailableTypes(this.ReferenceType);
            foreach (var chunk in cr2w.chunks.Where(_ => availableChunks.Contains(_.REDType)))
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

            // select item
            if (Reference == null)
                editor.SelectedIndex = 0;
            else
            {
                int selIndex = 0;
                for (int i = 0; i < editor.Items.Count; i++)
                {
                    if (editor.Items[i].ToString() == $"{Reference.REDType} #{Reference.ChunkIndex}")
                    {
                        selIndex = i;
                        break;
                    }
                }

                editor.SelectedIndex = selIndex;
            }
            
            return editor;
        }

        public override string ToString()
        {
            if (Reference == null)
                return "NULL";
            return $"{Reference.REDType} #{Reference.ChunkIndex}";
        }

        //public override void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);
        //        xw.WriteElementString("PtrTargetType", GetPtrTargetType());
        //        xw.WriteElementString("Target", ToString());
        //        ser.WriteEndObject(xw);
        //    }
        //}
        #endregion
    }

    public class PtrComboItem
    {
        public CR2WExportWrapper Value { get; set; }
        public string Text { get; set; }

        public override string ToString() => Text;
    }
}