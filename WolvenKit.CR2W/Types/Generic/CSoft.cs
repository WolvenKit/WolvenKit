using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using System.Linq;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    public interface ISoftAccessor
    {
        string DepotPath { get; set; }
        string ClassName { get; set; }
        string REDName { get; }
        string REDType { get; }
    }


    [REDMeta()]
    public class CSoft<T> : CVariable, ISoftAccessor where T : CVariable
    {
        public CSoft(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
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
                DepotPath = "";
                ClassName = "";
                Flags = 4;
            }
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            ushort val = 0;

            var import = cr2w.imports.FirstOrDefault(_ => _.DepotPathStr == DepotPath && _.ClassNameStr == ClassName && _.Flags == Flags);
            val = (ushort)(cr2w.imports.IndexOf(import) + 1);


            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is ushort)
            {
                this.SetValueInternal((ushort) val);
            }
            return this;
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CSoft<T>(cr2w, parent, name);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSoft<T>) base.Copy(context);

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
            editor.HandlePath.DataBindings.Add("Text", this, nameof(DepotPath), true, DataSourceUpdateMode.OnPropertyChanged);
            editor.FileType.DataBindings.Add("Text", this, nameof(ClassName), true, DataSourceUpdateMode.OnPropertyChanged);
            editor.Flags.DataBindings.Add("Text", this, nameof(Flags), true, DataSourceUpdateMode.OnPropertyChanged);
            return editor;
        }
        #endregion

    }
}