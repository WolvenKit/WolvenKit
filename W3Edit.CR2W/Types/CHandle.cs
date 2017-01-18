using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace W3Edit.CR2W.Types
{
    public class CHandle : CVariable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public Int32 val
        {
            get
            {
                if (ChunkHandle)
                {
                    return ChunkIndex;
                }
                else
                {
                    var newfiletype = (UInt16)cr2w.GetStringIndex(FileType, true);
                    return (-cr2w.GetHandleIndex(Handle, newfiletype, Flags, true) - 1);
                }
            }
            set
            {
                ChunkHandle = value >= 0;

                if (ChunkHandle)
                {
                    ChunkIndex = value;
                }
                else
                {
                    Handle = cr2w.handles[-value - 1].str;

                    var filetype = cr2w.handles[-value - 1].filetype;
                    FileType = cr2w.strings[filetype].str;

                    Flags = cr2w.handles[-value - 1].flags;
                }
            }
        }

        public string Handle { get; set; }
        public string FileType { get; set; }
        public UInt16 Flags { get; set; }
        public bool ChunkHandle { get; set; }

        public int ChunkIndex { get; set; }

        public CHandle(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
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
                this.val = (int)val;
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

            var.Handle = Handle;
            var.FileType = FileType;
            var.Flags = Flags;
            var.ChunkHandle = ChunkHandle;
            var.ChunkIndex = ChunkIndex;
            return var;
        }

        public override string ToString()
        {
            if (ChunkHandle)
            {
                if (ChunkIndex == 0)
                    return "0";

                if (ChunkIndex - 1 < 0 || ChunkIndex - 1 >= cr2w.chunks.Count)
                    return "Invalid Chunk handle";

                return "Chunk handle: " + cr2w.chunks[ChunkIndex-1].Type + " #" + (ChunkIndex);
            }

            return FileType + ": " + Handle;
        }

        internal class HandleComboItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            if (ChunkHandle)
            {
                var editor = new System.Windows.Forms.ComboBox();
                editor.Items.Add(new HandleComboItem() { Text = "", Value = 0 });

                for (int i = 0; i < cr2w.chunks.Count; i++ )
                {
                    editor.Items.Add(new HandleComboItem() { Text = cr2w.chunks[i].Type + " #" + (i+1).ToString(), Value = i + 1 });
                }

                editor.SelectedIndexChanged += delegate(object sender, EventArgs e)
                {
                    var item = (HandleComboItem)((System.Windows.Forms.ComboBox)sender).SelectedItem;
                    if (item != null)
                    {
                        ChunkIndex = item.Value;
                    }
                };

                var selIndex = ChunkIndex;
                if (selIndex < editor.Items.Count && selIndex >= 0)
                {
                    editor.SelectedIndex = selIndex;
                }
                return editor;
            }
            else
            {
                var editor = new W3Edit.CR2W.Editors.PtrEditor();
                editor.HandlePath.DataBindings.Add("Text", this, "Handle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
                editor.FileType.DataBindings.Add("Text", this, "FileType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
                editor.Flags.DataBindings.Add("Text", this, "Flags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
                return editor;
            }
        }
    }
}
