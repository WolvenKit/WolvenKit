using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace ="")]
    public class CHandle : CVariable
    {
        public CHandle(CR2WFile cr2w) : base(cr2w)
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public int val
        {
            get
            {
                if (ChunkHandle)
                {
                    return ChunkIndex;
                }
                var newfiletype = (ushort) cr2w.GetStringIndex(FileType, true);
                return (-cr2w.GetHandleIndex(Handle, newfiletype, Flags, true) - 1);
            }
            set
            {
                ChunkHandle = value >= 0;

                if (ChunkHandle)
                {
                    if (value <= cr2w.chunks.Count)
                        ChunkIndex = value;
                }
                else
                {
                    if (-value - 1 <= cr2w.imports.Count)
                    {
                        Handle = cr2w.imports[-value - 1].DepotPathStr;

                        var filetype = cr2w.imports[-value - 1].Import.className;
                        FileType = cr2w.names[filetype].Str;

                        Flags = cr2w.imports[-value - 1].Import.flags;
                    }
                }
            }
        }
        [DataMember(EmitDefaultValue = false)]
        public string Handle { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public string FileType { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public ushort Flags { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public bool ChunkHandle { get; set; }
        [DataMember(EmitDefaultValue = false)]
        public int ChunkIndex { get; set; }

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
            return new CHandle(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CHandle) base.Copy(context);

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

                return "Chunk handle: " + cr2w.chunks[ChunkIndex - 1].Type + " #" + (ChunkIndex);
            }

            return FileType + ": " + Handle;
        }

        public override Control GetEditor()
        {
            if (ChunkHandle)
            {
                var editor = new ComboBox();
                editor.Items.Add(new HandleComboItem {Text = "", Value = 0});

                for (var i = 0; i < cr2w.chunks.Count; i++)
                {
                    editor.Items.Add(new HandleComboItem {Text = cr2w.chunks[i].Type + " #" + (i + 1), Value = i + 1});
                }

                editor.SelectedIndexChanged += delegate(object sender, EventArgs e)
                {
                    var item = (HandleComboItem) ((ComboBox) sender).SelectedItem;
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
                var editor = new PtrEditor();
                editor.HandlePath.DataBindings.Add("Text", this, "Handle", true, DataSourceUpdateMode.OnPropertyChanged);
                editor.FileType.DataBindings.Add("Text", this, "FileType", true, DataSourceUpdateMode.OnPropertyChanged);
                editor.Flags.DataBindings.Add("Text", this, "Flags", true, DataSourceUpdateMode.OnPropertyChanged);
                return editor;
            }
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
    }
}