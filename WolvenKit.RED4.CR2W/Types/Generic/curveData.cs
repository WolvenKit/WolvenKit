using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Core.Exceptions;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CurvePoint<T> : CVariable, IREDCurvePoint where T : CVariable
    {
        [RED] public T Value { get; set; }
        [RED] public CFloat Time { get; set; }

        public CurvePoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public object GetValue() => new Tuple<IEditableVariable, IEditableVariable>(Value, Time);

        public void Init()
        {
            Value = Create<T>(nameof(Value));
            Value.IsSerialized = true;
            Time = Create<CFloat>(nameof(Time));
            Time.IsSerialized = true;
        }

        public override List<IEditableVariable> GetEditableVariables() => new() { Time, Value };

        public override string ToString() => $"[{Time.Value}] {Value}";


        public float GetTime() => Time.Value;
    }

    [REDMeta]
    public class curveData<T> : CVariable, ICurveDataAccessor where T : CVariable
    {


        public curveData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            InterpolationType = Create<CUInt8>(nameof(InterpolationType));
            LinkType = Create<CUInt8>(nameof(LinkType));
        }

        public string Elementtype => REDReflection.GetREDTypeString(typeof(T));

        public List<CurvePoint<T>> Elements { get; set; } = new();

        [REDBuffer] public CUInt8 InterpolationType { get; set; }

        [REDBuffer] public CUInt8 LinkType { get; set; }

        public override string REDType => REDReflection.GetREDTypeString(GetType());

        public override void Read(BinaryReader file, uint size)
        {
            var pos = file.BaseStream.Position;
            var count = file.ReadUInt32();


            for (int i = 0; i < count; i++)
            {
                var cpoint = new CurvePoint<T>(cr2w, this, i.ToString()) { IsSerialized = true };

                var point = new CFloat(cr2w, cpoint, "time") { IsSerialized = true };
                var value = Create<T>("value", Array.Empty<int>());

                point.Read(file, 4);
                // no actual way to find out the elementsize of an array element
                // bacause cdpr serialized classes have no fixed size
                // solution? not sure: pass 0 and disable checks?
                value.ReadAsFixedSize(file, (uint)0);


                value.IsSerialized = true;

                cpoint.Time = point;
                cpoint.Value = value;
                Elements.Add(cpoint);
            }

            InterpolationType.Read(file, 1);
            LinkType.Read(file, 1);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write((uint)Elements.Count);

            foreach (var curvePoint in Elements)
            {
                curvePoint.Time.Write(file);
                curvePoint.Value.WriteAsFixedSize(file);
            }

            InterpolationType.Write(file);
            LinkType.Write(file);
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

        public IEditableVariable GetInterpolationType() => InterpolationType;

        public IEditableVariable GetLinkType() => LinkType;



        public override List<IEditableVariable> GetEditableVariables() => Elements.Cast<IEditableVariable>().ToList();
    }


}
