using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CSoft : CVariable
    {
        public CSoft(CR2WFile cr2w)
            : base(cr2w)
        {
        }

        [DataMember(EmitDefaultValue = false)]
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
                    Handle = cr2w.imports[value - 1].DepotPathStr;

                    var filetype = cr2w.imports[value - 1].Import.className;
                    FileType = cr2w.names[filetype].Str;

                    Flags = cr2w.imports[value - 1].Import.flags;
                }
                else
                {
                    if (cr2w.imports.Count > 0)
                    {
                        Handle = cr2w.imports[0].DepotPathStr;

                        var filetype = cr2w.imports[0].Import.className;
                        FileType = cr2w.names[filetype].Str;

                        Flags = cr2w.imports[0].Import.flags;
                    }
                    else
                    {
                        Handle = "";
                        FileType = "";
                        Flags = 0;
                    }
                    
                    //TODO: Log this to console: The file is corrupted but we tried to load it anyway so something may not function properly!
                }
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string Handle { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FileType { get; set; }

        [DataMember(EmitDefaultValue = false)]
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