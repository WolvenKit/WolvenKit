using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.Common;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Core.Exceptions;
using WolvenKit.RED4.CR2W.Reflection;

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

        public override List<IEditableVariable> GetEditableVariables() => new() { Point, Value };

        public override string ToString() => $"[{Point.Value}] {Value}";


        public float GetTime() => Point.Value;
    }

    [REDMeta]
    public class curveData<T> : CVariable, ICurveDataAccessor where T : CVariable
    {
        public curveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public string Elementtype => REDReflection.GetREDTypeString(typeof(T));

        private List<CurvePoint<T>> Elements { get; set; } = new();

        private EInterpolationType InterpolationType { get; set; }

        private ESegmentsLinkType LinkType { get; set; }

        public override string REDType => REDReflection.GetREDTypeString(GetType());

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadUInt32();


            for (int i = 0; i < count; i++)
            {
                var cpoint = new CurvePoint<T>(cr2w, this, i.ToString()) { IsSerialized = true };

                var point = new CFloat(cr2w, cpoint, "point") { IsSerialized = true };
                var value = Create<T>(i.ToString(), new int[0]);

                point.Read(file, 4);
                // no actual way to find out the elementsize of an array element
                // bacause cdpr serialized classes have no fixed size
                // solution? not sure: pass 0 and disable checks?
                value.ReadAsFixedSize(file, (uint)0);


                value.IsSerialized = true;

                cpoint.Point = point;
                cpoint.Value = value;
                Elements.Add(cpoint);
            }


            InterpolationType = (EInterpolationType)file.ReadByte();
            LinkType = (ESegmentsLinkType)file.ReadByte();
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((uint)Elements.Count);

            foreach (var curvePoint in Elements)
            {
                curvePoint.Point.Write(file);
                curvePoint.Value.WriteAsFixedSize(file);
            }

            file.Write((byte)InterpolationType);
            file.Write((byte)LinkType);
        }

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

        public IEnumerable<IREDCurvePoint> GetCurvePoints() => Elements;

        public void SetCurvePoints(IEnumerable<Tuple<double, object>> points)
        {
            Elements.Clear();

            var i = 0;
            foreach (var (t, v) in points)
            {
                var cpoint = new CurvePoint<T>(cr2w, this, i.ToString()) { IsSerialized = true };

                var point = new CFloat(cr2w, cpoint, "point") { IsSerialized = true, Value = (float)t };
                var value = Create<T>(i.ToString(), Array.Empty<int>());
                value.SetValue(v);

                value.IsSerialized = true;

                cpoint.Point = point;
                cpoint.Value = value;
                Elements.Add(cpoint);

                i++;
            }

        }

        public void SetLinkType(ESegmentsLinkType type) => LinkType = type;

        public EInterpolationType GetInterpolationType() => InterpolationType;

        public void SetInterpolationType(EInterpolationType type) => InterpolationType = type;

        public ESegmentsLinkType GetLinkType() => LinkType;
    }


}
