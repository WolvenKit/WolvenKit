using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta()]
    public class LocalizationString : CVariable, IREDPrimitive
    {
        

        public LocalizationString(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Unk1 = new CUInt64(cr2w, this, nameof(Unk1));
            Value = new CString(cr2w, this, nameof(Value));
        }

        #region Properties

        public CUInt64 Unk1;
        public CString Value;
        #endregion


        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            Unk1.Read(file, 8);
            Value.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            Unk1.Write(file);
            Value.Write(file);
        }

        public override string ToString() => $"{Value}";

        public override List<IEditableVariable> GetEditableVariables() => new() { Unk1, Value };
        #endregion

    }
}