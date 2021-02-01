using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using CP77.CR2W.Reflection;
using FastMember;

namespace CP77.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CurvePoint<T> : CVariable where T : CVariable
    {
        public T Value { get; set; }
        public CFloat Point { get; set; }

        public CurvePoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }



    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
    public class curveData<T> : CVariable, ICurveDataAccessor where T : CVariable
    {
        

        public curveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string Elementtype { get; set; }

        private List<CurvePoint<T>> Elements { get; set; } = new();
        public uint Tail { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadUInt32();

            
            for (int i = 0; i < count; i++)
            {
                var cpoint = new CurvePoint<T>(cr2w, this, i.ToString()) {IsSerialized = true};

                var point = new CFloat(cr2w, cpoint, "point") { IsSerialized = true };
                CVariable element = CR2WTypeManager.Create(Elementtype, i.ToString(), cr2w, cpoint);

                // no actual way to find out the elementsize of an array element
                // bacause cdpr serialized classes have no fixed size
                // solution? not sure: pass 0 and disable checks?
                element.ReadAsFixedSize(file, (uint)0);
                point.Read(file, 4);

                if (element is T te)
                {
                    te.IsSerialized = true;

                    cpoint.Point = point;
                    cpoint.Value = te;

                    Elements.Add(cpoint);
                }
            }

            Tail = file.ReadUInt16();
            var pos2 = file.BaseStream.Position;
            if (size != (pos2 - pos))
            {

            }
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return Elements.Cast<IEditableVariable>().ToList();
        }


    }


}
