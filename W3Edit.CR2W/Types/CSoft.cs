using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace W3Edit.CR2W.Types
{
    public class CSoft : CVariable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public UInt16 val
        {
            get
            {
                var newfiletype = (UInt16)cr2w.GetStringIndex(FileType, true);
                return (UInt16)(cr2w.GetHandleIndex(Handle, newfiletype, Flags, true) + 1);
            }
            set
            {
                Handle = cr2w.handles[value - 1].str;

                var filetype = cr2w.handles[value - 1].filetype;
                FileType = cr2w.strings[filetype].str;

                Flags = cr2w.handles[value - 1].flags;
            }
        }

        public string Handle { get; set; }

        public string FileType { get; set; }

        public ushort Flags { get; set; }

        public CSoft(CR2WFile cr2w)
            : base(cr2w)
        {

        }

        public override void Read(BinaryReader file, UInt32 size)
        {
            val = file.ReadUInt16();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is UInt16)
            {
                this.val = (UInt16)val;
            }
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSoft(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSoft)base.Copy(context);

            var.FileType = FileType;
            var.Flags = Flags;
            var.Handle = Handle;
            return var;
        }

        public override string ToString()
        {
            return FileType + ": " + Handle;
        }

        public override System.Windows.Forms.Control GetEditor()
        {
            var editor = new W3Edit.CR2W.Editors.PtrEditor();
            editor.HandlePath.DataBindings.Add("Text", this, "Handle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            editor.FileType.DataBindings.Add("Text", this, "FileType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            editor.Flags.DataBindings.Add("Text", this, "Flags", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            return editor;
        }
    }
}
