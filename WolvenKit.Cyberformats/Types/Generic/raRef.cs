using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using CP77.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace CP77.CR2W.Types
{
    /// <summary>
    /// CSofts are Uint16 references to the imports table of a cr2w file
    /// Imports are paths to a file in the tw3 filesystem
    /// and can be set manually by DepotPath and Classname
    /// Imports have flags which are set on write
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [REDMeta()]
    public class raRef<T> : CVariable, ISoftAccessor where T : CVariable
    {
        public raRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }


        #region Properties
        [DataMember(EmitDefaultValue = false)]
        public string DepotPath { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        //public string ClassName { get; set; }

        //[DataMember(EmitDefaultValue = false)]
        public EImportFlags Flags { get; set; }
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
                DepotPath = cr2w.Imports[value - 1].DepotPathStr;

                //var filetype = cr2w.Imports[value - 1].Import.className;
                //ClassName = cr2w.Names[filetype].Str;

                Flags = (EImportFlags)cr2w.Imports[value - 1].Flags;
            }
            else
            {
                DepotPath = "";
                //ClassName = "";
                Flags = EImportFlags.Default;
            }
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            ushort val = 0;

            var import = cr2w.Imports.FirstOrDefault(_ => _.DepotPathStr == DepotPath /*&& _.ClassNameStr == ClassName && _.Flags == Flags*/);
            val = (ushort)(cr2w.Imports.IndexOf(import) + 1);


            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case ushort o:
                    this.SetValueInternal(o);
                    break;
                case ISoftAccessor soft:
                    this.DepotPath = soft.DepotPath;
                    //this.ClassName = cvar.ClassName;
                    this.Flags = soft.Flags;
                    break;
            }

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var copy = (raRef<T>)base.Copy(context);

            //copy.ClassName = ClassName;
            copy.Flags = Flags;
            copy.DepotPath = DepotPath;
            return copy;
        }

        public override string ToString() => /*ClassName + ": " +*/ $"[{Flags}]{DepotPath}";


        #endregion

    }
}
