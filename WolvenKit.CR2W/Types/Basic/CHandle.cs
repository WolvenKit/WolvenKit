using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using System.Linq;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CHandle : CVariable
    {
        public CHandle(CR2WFile cr2w) : base(cr2w)
        {
        }

        #region Properties
        [DataMember(EmitDefaultValue = false)]
        public bool ChunkHandle { get; set; }

        // Resource
        [DataMember(EmitDefaultValue = false)]
        public string DepotPath { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ClassName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ushort Flags { get; set; }

        // Reference
        [DataMember(EmitDefaultValue = false)]
        public CR2WExportWrapper Reference { get; set; }
        #endregion

        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            SetValueInternal(file.ReadInt32());
        }

        private void SetValueInternal(int val)
        {
            if (val >= 0)
                this.ChunkHandle = true;


            if (ChunkHandle)
            {
                if (val == 0)
                    Reference = null;
                else
                    Reference = cr2w.chunks[val - 1];
            }
            else
            {
                DepotPath = cr2w.imports[-val - 1].DepotPathStr;

                var filetype = cr2w.imports[-val - 1].Import.className;
                ClassName = cr2w.names[filetype].Str;

                Flags = cr2w.imports[-val - 1].Import.flags;
            }
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            int val = 0;
            if (ChunkHandle)
            {
                if (Reference != null)
                    val = Reference.ChunkIndex + 1;
            }
            else
            {
                try
                {
                    var import = cr2w.imports.FirstOrDefault(_ => _.DepotPathStr == DepotPath && _.ClassNameStr == ClassName);
                    val = - cr2w.imports.IndexOf(import) - 1;
                }
                catch (Exception)
                {
                }
            }
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is int)
            {
                SetValueInternal((int)val);
            }

            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CHandle(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CHandle)base.Copy(context);

            var.DepotPath = DepotPath;
            var.ClassName = ClassName;
            var.Flags = Flags;
            var.ChunkHandle = ChunkHandle;
            var.Reference = Reference;
            return var;
        }

        public override string ToString()
        {
            if (ChunkHandle)
            {
                if (Reference == null)
                    return "NULL";
                else
                    return Reference.Type + " #" + (Reference.ChunkIndex);
            }

            return ClassName + ": " + DepotPath;
        }

        public override Control GetEditor()
        {
            if (ChunkHandle)
            {
                var editor = new ComboBox();
                editor.Items.Add(new PtrComboItem { Text = "", Value = null });

                foreach (var chunk in cr2w.chunks)
                {
                    editor.Items.Add(new PtrComboItem
                    {
                        Text = $"{chunk.Type} #{chunk.ChunkIndex}", //real index
                        Value = chunk
                    }
                    );
                }

                editor.SelectedIndexChanged += delegate (object sender, EventArgs e)
                {
                    var ptrcomboitem = (PtrComboItem)((ComboBox)sender).SelectedItem;
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
            else
            {
                var editor = new PtrEditor();
                editor.HandlePath.DataBindings.Add("Text", this, nameof(DepotPath), true, DataSourceUpdateMode.OnPropertyChanged);
                editor.FileType.DataBindings.Add("Text", this, nameof(ClassName), true, DataSourceUpdateMode.OnPropertyChanged);
                editor.Flags.DataBindings.Add("Text", this, nameof(Flags), true, DataSourceUpdateMode.OnPropertyChanged);
                return editor;
            }
        }
        #endregion

        internal class HandleComboItem
        {
            public int Value { get; set; }
            public string Text { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}