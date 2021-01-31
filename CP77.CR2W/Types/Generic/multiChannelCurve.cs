using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
    public class multiChannelCurve<T> : CVariable, ICurveDataAccessor where T : CVariable
    {
       

        public multiChannelCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string Elementtype { get; set; }

        private List<CurvePoint<T>> Elements { get; set; } = new();
        public uint Tail { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadUInt32();


            throw new NotImplementedException($"multiChannelCurve");
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return Elements.Cast<IEditableVariable>().ToList();
        }
    }


}
