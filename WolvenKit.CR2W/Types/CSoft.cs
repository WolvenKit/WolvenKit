using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CSoft : CVariable
    {
        public CSoft(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ushort val
        {
            get
            {
                var newfiletype = (ushort) cr2w.GetStringIndex(FileType, true);
                return (ushort) (cr2w.GetHandleIndex(Handle, newfiletype, Flags, true) + 1);
            }
            set
            {
                if (value > 0)
                {
                    Handle = cr2w.handles[value - 1].str;

                    var filetype = cr2w.handles[value - 1].filetype;
                    FileType = cr2w.strings[filetype].str;

                    Flags = cr2w.handles[value - 1].flags;
                }
                else
                {
                    Handle = cr2w.handles[0].str;

                    var filetype = cr2w.handles[0].filetype;
                    FileType = cr2w.strings[filetype].str;

                    Flags = cr2w.handles[0].flags;
                    //TODO: Log this to console: The file is corrupted but we tried to load it anyway so something may not function properly!
                }
            }
        }

        public string Handle { get; set; }
        public string FileType { get; set; }
        public ushort Flags { get; set; }

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
            if (val is ushort)
            {
                this.val = (ushort) val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSoft(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSoft) base.Copy(context);

            var.FileType = FileType;
            var.Flags = Flags;
            var.Handle = Handle;
            return var;
        }

        public override string ToString()
        {
            return FileType + ": " + Handle;
        }

        public override Control GetEditor()
        {
            var editor = new PtrEditor();
            editor.HandlePath.DataBindings.Add("Text", this, "Handle", true, DataSourceUpdateMode.OnPropertyChanged);
            editor.FileType.DataBindings.Add("Text", this, "FileType", true, DataSourceUpdateMode.OnPropertyChanged);
            editor.Flags.DataBindings.Add("Text", this, "Flags", true, DataSourceUpdateMode.OnPropertyChanged);
            return editor;
        }
    }
}