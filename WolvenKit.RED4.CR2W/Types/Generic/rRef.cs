using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using WolvenKit.Common;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;

namespace WolvenKit.RED4.CR2W.Types
{
    /// <summary>
    /// CSofts are Uint16 references to the imports table of a cr2w file
    /// Imports are paths to a file in the tw3 filesystem
    /// and can be set manually by DepotPath and Classname
    /// Imports have flags which are set on write
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [REDMeta()]
    public class rRef<T> : CVariable, IREDRef where T : CVariable
    {
        public rRef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties

        public string DepotPath { get; set; }

        public EImportFlags Flags { get; set; }

        #endregion

        #region Methods
        public override void Read(BinaryReader file, uint size) => SetValueInternal(file.ReadUInt16());

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

                throw new InvalidParsingException("rRef");
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
            this.IsSerialized = true;
            switch (val)
            {
                case ushort o:
                    this.SetValueInternal(o);
                    break;
                case IREDRef soft:
                    this.DepotPath = soft.DepotPath;
                    //this.ClassName = cvar.ClassName;
                    this.Flags = soft.Flags;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return this;
        }

        public object GetValue() => DepotPath;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var copy = (rRef<T>)base.Copy(context);

            //copy.ClassName = ClassName;
            copy.Flags = Flags;
            copy.DepotPath = DepotPath;
            return copy;
        }

        public override string ToString() => /*ClassName + ": " +*/ $"[{Flags}]{DepotPath}";


        #endregion

    }
}
