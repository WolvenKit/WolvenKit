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
    public class curveData<T> : CVariable, ICurveDataAccessor where T : CVariable
    {
        

        public curveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string Elementtype { get; set; }

        public List<T> Elements { get; set; } = new List<T>();
        public uint Tail { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadUInt32();

            var elementcount = count * 2;
            if (count == 2 && size == 26) //FIXME: pls
            {
                elementcount = 5;
            }

            for (int i = 0; i < elementcount; i++)
            {
                CVariable element = CR2WTypeManager.Create(Elementtype, i.ToString(), cr2w, this);

                // no actual way to find out the elementsize of an array element
                // bacause cdpr serialized classes have no fixed size
                // solution? not sure: pass 0 and disable checks?
                element.Read(file, (uint)0);
                if (element is T te)
                {
                    te.IsSerialized = true;
                    Elements.Add(te);
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
