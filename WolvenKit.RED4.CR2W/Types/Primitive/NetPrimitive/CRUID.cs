using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta()]
    public class CRUID : CVariable, IREDIntegerType<ulong>
    {
        public CRUID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        #region Properties

        public ulong Value { get; set; }

        #endregion

        #region Methods
        public override void Read(BinaryReader file, uint size)=> Value = file.ReadUInt64();

        public override void Write(BinaryWriter file)=> file.Write(Value);

        public object GetValue() => Value;

        public override string ToString() => $"{Value}";

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var var = (CRUID)base.Copy(context);
            var.Value = Value;
            return var;
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            this.Value = val switch
            {
                ulong o => o,
                string s => ulong.Parse(s),
                CUInt64 v => v.Value,
                _ => this.Value
            };

            return this;
        }

        #endregion

    }
}
