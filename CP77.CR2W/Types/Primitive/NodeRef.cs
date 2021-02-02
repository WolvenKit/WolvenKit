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
    public class NodeRef : CVariable, IREDPrimitive
    {


        public NodeRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Value = new CString(cr2w, this, nameof(Value));
        }

        #region Properties

        public CString Value;
        #endregion


        #region Methods
        public override void Read(BinaryReader file, uint size)
        {
            Value.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            Value.Write(file);
        }

        public override string ToString() => $"{Value}";

        public override List<IEditableVariable> GetEditableVariables() => new() { Value };
        #endregion

    }
}