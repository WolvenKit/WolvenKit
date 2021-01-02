using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /// <summary>
    /// CSofts are Uint16 references to the imports table of a cr2w file
    /// Imports are paths to a file in the tw3 filesystem
    /// and can be set manually by DepotPath and Classname
    /// Imports have flags which are set on write
    /// </summary>
    /// <typeparam name="T"></typeparam>
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
                DepotPath = cr2w.Imports[value - 1].DepotPathStr;

                var filetype = cr2w.Imports[value - 1].Import.className;
                ClassName = cr2w.Names[filetype].Str;

                Flags = cr2w.Imports[value - 1].Import.flags;
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

            var import = cr2w.Imports.FirstOrDefault(_ => _.DepotPathStr == DepotPath && _.ClassNameStr == ClassName && _.Flags == Flags);
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
                case ISoftAccessor cvar:
                    this.DepotPath = cvar.DepotPath;
                    this.ClassName = cvar.ClassName;
                    this.Flags = cvar.Flags;
                    break;
            }

            return this;
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = (CSoft<T>) base.Copy(context);

            copy.ClassName = ClassName;
            copy.Flags = Flags;
            copy.DepotPath = DepotPath;
            return copy;
        }

        public override string ToString() => ClassName + ": " + DepotPath;

        
        #endregion

    }
}