using System;
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


        #region Properties
        [DataMember(EmitDefaultValue = false)]
        public string DepotPath { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ClassName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ushort Flags { get; set; }
        #endregion

        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            SetValueInternal(file.ReadUInt16());
        }
        
        private void SetValueInternal(ushort value)
        {
            if (value > 0)
            {
                DepotPath = cr2w.imports[value - 1].DepotPathStr;

                var filetype = cr2w.imports[value - 1].Import.className;
                ClassName = cr2w.names[filetype].Str;

                Flags = cr2w.imports[value - 1].Import.flags;
            }
            else
            {
                if (cr2w.imports.Count > 0)
                {
                    DepotPath = cr2w.imports[0].DepotPathStr;

                    var filetype = cr2w.imports[0].Import.className;
                    ClassName = cr2w.names[filetype].Str;

                    Flags = cr2w.imports[0].Import.flags;
                }
                else
                {
                    DepotPath = "";
                    ClassName = "";
                    Flags = 0;
                }

                //TODO: Log this to console: The file is corrupted but we tried to load it anyway so something may not function properly!
            }
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            throw new NotImplementedException();
            //file.Write(_val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is ushort)
            {
                this.SetValueInternal((ushort) val);
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

            var.ClassName = ClassName;
            var.Flags = Flags;
            var.DepotPath = DepotPath;
            return var;
        }

        public override string ToString()
        {
            return ClassName + ": " + DepotPath;
        }

        public override Control GetEditor()
        {
            var editor = new PtrEditor();
            editor.HandlePath.DataBindings.Add("Text", this, "Handle", true, DataSourceUpdateMode.OnPropertyChanged);
            editor.FileType.DataBindings.Add("Text", this, "FileType", true, DataSourceUpdateMode.OnPropertyChanged);
            editor.Flags.DataBindings.Add("Text", this, "Flags", true, DataSourceUpdateMode.OnPropertyChanged);
            return editor;
        }
        #endregion

    }
}