using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMultiCurve : CVariable
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<ECurveType> Type { get; set;}

		[Ordinal(2)] [RED("color")] 		public CColor Color { get; set;}

		[Ordinal(3)] [RED("showFlags")] 		public CEnum<EShowFlags> ShowFlags { get; set;}

		[Ordinal(4)] [RED("positionInterpolationMode")] 		public CEnum<ECurveInterpolationMode> PositionInterpolationMode { get; set;}

		[Ordinal(5)] [RED("positionManualMode")] 		public CEnum<ECurveManualMode> PositionManualMode { get; set;}

		[Ordinal(6)] [RED("rotationInterpolationMode")] 		public CEnum<ECurveInterpolationMode> RotationInterpolationMode { get; set;}

		[Ordinal(7)] [RED("totalTime")] 		public CFloat TotalTime { get; set;}

		[Ordinal(8)] [RED("automaticPositionInterpolationSmoothness")] 		public CFloat AutomaticPositionInterpolationSmoothness { get; set;}

		[Ordinal(9)] [RED("automaticRotationInterpolationSmoothness")] 		public CFloat AutomaticRotationInterpolationSmoothness { get; set;}

		[Ordinal(10)] [RED("enableConsistentNumberOfControlPoints")] 		public CBool EnableConsistentNumberOfControlPoints { get; set;}

		[Ordinal(11)] [RED("enableAutomaticTimeByDistanceRecalculation")] 		public CBool EnableAutomaticTimeByDistanceRecalculation { get; set;}

		[Ordinal(12)] [RED("enableAutomaticTimeRecalculation")] 		public CBool EnableAutomaticTimeRecalculation { get; set;}

		[Ordinal(13)] [RED("enableAutomaticRotationFromDirectionRecalculation")] 		public CBool EnableAutomaticRotationFromDirectionRecalculation { get; set;}

		[Ordinal(14)] [RED("curves", 2,0)] 		public CArray<SCurveData> Curves { get; set;}

		[Ordinal(15)] [RED("leftTangents", 142,0)] 		public CArray<Vector> LeftTangents { get; set;}

		[Ordinal(16)] [RED("rightTangents", 142,0)] 		public CArray<Vector> RightTangents { get; set;}

		[Ordinal(17)] [RED("easeParams", 2,0)] 		public CArray<SCurveEaseParam> EaseParams { get; set;}

		[Ordinal(18)] [RED("translationRelativeMode")] 		public CEnum<ECurveRelativeMode> TranslationRelativeMode { get; set;}

		[Ordinal(19)] [RED("rotationRelativeMode")] 		public CEnum<ECurveRelativeMode> RotationRelativeMode { get; set;}

		[Ordinal(20)] [RED("scaleRelativeMode")] 		public CEnum<ECurveRelativeMode> ScaleRelativeMode { get; set;}

		[Ordinal(21)] [RED("initialParentTransform")] 		public EngineTransform InitialParentTransform { get; set;}

		[Ordinal(22)] [RED("hasInitialParentTransform")] 		public CBool HasInitialParentTransform { get; set;}

		public SMultiCurve(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMultiCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}