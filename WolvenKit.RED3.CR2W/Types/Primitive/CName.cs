using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using WolvenKit.RED3.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta()]
    public class CName : CVariable, IREDString
    {
        public CName()
        {

        }

        public CName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties
        [DataMember]
        public string Value { get; set; }
        #endregion


        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            var idx = file.ReadUInt16();
            Value = cr2w.Names[idx].Str;
        }

        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            ushort val = 0;

            var nw = cr2w.Names.First(_ => _.Str == Value);
            val = (ushort)cr2w.Names.IndexOf(nw);

            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            if (val is string)
            {
                Value = (string)val;
            }
            else if (val is CName cval)
                Value = cval.Value;

            return this;
        }

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CName)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override string ToString()
        {
            return Value;
        }
        #endregion

    }
}
