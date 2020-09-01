using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMultiCurve : CVariable
	{
		[Ordinal(0)] [RED("("type")] 		public CEnum<ECurveType> Type { get; set;}

		[Ordinal(0)] [RED("("color")] 		public CColor Color { get; set;}

		[Ordinal(0)] [RED("("showFlags")] 		public CEnum<EShowFlags> ShowFlags { get; set;}

		[Ordinal(0)] [RED("("positionInterpolationMode")] 		public CEnum<ECurveInterpolationMode> PositionInterpolationMode { get; set;}

		[Ordinal(0)] [RED("("positionManualMode")] 		public CEnum<ECurveManualMode> PositionManualMode { get; set;}

		[Ordinal(0)] [RED("("rotationInterpolationMode")] 		public CEnum<ECurveInterpolationMode> RotationInterpolationMode { get; set;}

		[Ordinal(0)] [RED("("totalTime")] 		public CFloat TotalTime { get; set;}

		[Ordinal(0)] [RED("("automaticPositionInterpolationSmoothness")] 		public CFloat AutomaticPositionInterpolationSmoothness { get; set;}

		[Ordinal(0)] [RED("("automaticRotationInterpolationSmoothness")] 		public CFloat AutomaticRotationInterpolationSmoothness { get; set;}

		[Ordinal(0)] [RED("("enableConsistentNumberOfControlPoints")] 		public CBool EnableConsistentNumberOfControlPoints { get; set;}

		[Ordinal(0)] [RED("("enableAutomaticTimeByDistanceRecalculation")] 		public CBool EnableAutomaticTimeByDistanceRecalculation { get; set;}

		[Ordinal(0)] [RED("("enableAutomaticTimeRecalculation")] 		public CBool EnableAutomaticTimeRecalculation { get; set;}

		[Ordinal(0)] [RED("("enableAutomaticRotationFromDirectionRecalculation")] 		public CBool EnableAutomaticRotationFromDirectionRecalculation { get; set;}

		[Ordinal(0)] [RED("("curves", 2,0)] 		public CArray<SCurveData> Curves { get; set;}

		[Ordinal(0)] [RED("("leftTangents", 142,0)] 		public CArray<Vector> LeftTangents { get; set;}

		[Ordinal(0)] [RED("("rightTangents", 142,0)] 		public CArray<Vector> RightTangents { get; set;}

		[Ordinal(0)] [RED("("easeParams", 2,0)] 		public CArray<SCurveEaseParam> EaseParams { get; set;}

		[Ordinal(0)] [RED("("translationRelativeMode")] 		public CEnum<ECurveRelativeMode> TranslationRelativeMode { get; set;}

		[Ordinal(0)] [RED("("rotationRelativeMode")] 		public CEnum<ECurveRelativeMode> RotationRelativeMode { get; set;}

		[Ordinal(0)] [RED("("scaleRelativeMode")] 		public CEnum<ECurveRelativeMode> ScaleRelativeMode { get; set;}

		[Ordinal(0)] [RED("("initialParentTransform")] 		public EngineTransform InitialParentTransform { get; set;}

		[Ordinal(0)] [RED("("hasInitialParentTransform")] 		public CBool HasInitialParentTransform { get; set;}

		public SMultiCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMultiCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}