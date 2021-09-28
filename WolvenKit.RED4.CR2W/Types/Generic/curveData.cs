using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CurvePoint<T> : CVariable, IREDCurvePoint where T : CVariable
    {
        [RED] public T Value { get; set; }
        [RED] public CFloat Point { get; set; }

        public CurvePoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public object GetValue() => new Tuple<IEditableVariable, IEditableVariable>(Value, Point);

        public void Init()
        {
            Value = Create<T>(nameof(Value));
            Value.IsSerialized = true;
            Point = Create<CFloat>(nameof(Point));
            Point.IsSerialized = true;
        }
    }



    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
    public class curveData<T> : CVariable, ICurveDataAccessor where T : CVariable
    {


        public curveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string Elementtype => REDReflection.GetREDTypeString(typeof(T));

        public List<CurvePoint<T>> Elements { get; set; } = new();
        public ushort Tail { get; set; }

        public override string REDType => REDReflection.GetREDTypeString(GetType());

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadUInt32();


            for (int i = 0; i < count; i++)
            {
                var cpoint = new CurvePoint<T>(cr2w, this, i.ToString()) {IsSerialized = true};

                var point = new CFloat(cr2w, cpoint, "point") { IsSerialized = true };
                var element = Create<T>(i.ToString(), new int[0]);

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

        public override void Write(BinaryWriter file)
        {
            file.Write((uint)Elements.Count);

            foreach (var curvePoint in Elements)
            {
                curvePoint.Value.WriteAsFixedSize(file);
                curvePoint.Point.Write(file);
            }

            file.Write(Tail);
        }

        public override List<IEditableVariable> GetEditableVariables() => Elements.Cast<IEditableVariable>().ToList();

        public IEditableVariable GetElementInstance(string varName)
        {
            var element = Create<CurvePoint<T>>(varName, Array.Empty<int>());
            if (element is not IEditableVariable evar)
            {
                throw new MissingRTTIException(varName, Elementtype, this.REDType);
            }
            element.Init();

            evar.IsSerialized = true;
            return evar;
        }

        public override void AddVariable(IEditableVariable variable)
        {
            if (variable is CurvePoint<T> tvar)
            {
                variable.SetREDName(Elements.Count.ToString());
                tvar.IsSerialized = true;
                Elements.Add(tvar);
            }
        }
    }


}
