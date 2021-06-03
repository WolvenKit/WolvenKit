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
    public class NodeRef : CVariable, IREDString
    {

        public NodeRef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties

        public string Value { get; set; }

        #endregion


        #region Methods

        public override void Read(BinaryReader file, uint size) => Value = file.ReadLengthPrefixedString();

        public override void Write(BinaryWriter file) => file.WriteLengthPrefixedString(Value);

        public override string ToString() => $"{Value}";

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            this.Value = val switch
            {
                string s => s,
                NodeRef cvar => cvar.Value,
                _ => this.Value
            };

            return this;
        }

        public object GetValue() => Value;

        #endregion

    }
}
