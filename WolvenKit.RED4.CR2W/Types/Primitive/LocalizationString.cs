using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Linq;
using FastMember;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class LocalizationString : CVariable
    {
        #region Properties

        private CUInt64 _cruid;
        private CString _locKey;

        [Ordinal(0)]
        [RED("stringId")]
        public CUInt64 CRUID
        {
            get => GetProperty(ref _cruid);
            set => SetProperty(ref _cruid, value);
        }

        [Ordinal(1)]
        [RED("locKey")]
        public CString Value
        {
            get => GetProperty(ref _locKey);
            set => SetProperty(ref _locKey, value);
        }

        public LocalizationString(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            CRUID = new CUInt64(cr2w, this, nameof(CRUID));
            Value = new CString(cr2w, this, nameof(Value));
        }
        #endregion

        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            CRUID.Read(file, 8);
            var strLen = file.ReadInt16();
            var strVal = Encoding.GetEncoding("ISO-8859-1").GetString(file.ReadBytes(strLen));
            Value.SetValue(strVal);
        }

        public override void Write(BinaryWriter file)
        {
            CRUID.Write(file);
            Value.Write(file);
        }

        public override string ToString() => $"{Value}";

        public override List<IEditableVariable> GetEditableVariables() => new() { CRUID, Value };
        #endregion

    }
}
