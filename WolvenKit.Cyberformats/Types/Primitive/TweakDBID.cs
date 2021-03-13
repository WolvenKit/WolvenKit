using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using WolvenKit.Common.Model.Cr2w;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta()]
    public class TweakDBID : CVariable, IREDPrimitive
    {


        public TweakDBID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Id = new CUInt64(cr2w, this, nameof(Id));
        }

        #region Properties

        public CUInt64 Id;
        #endregion


        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            Id.Read(file, 8);
        }

        public override void Write(BinaryWriter file)
        {
            Id.Write(file);
        }

        public override string ToString() => $"{Id}";

        public override List<IEditableVariable> GetEditableVariables() => new() { Id };
        #endregion
    }
}