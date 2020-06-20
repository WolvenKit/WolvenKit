using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMultiCurve : CVariable
	{
		[RED("type")] 		public CEnum<ECurveType> Type { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		[RED("showFlags")] 		public CEnum<EShowFlags> ShowFlags { get; set;}

		[RED("positionInterpolationMode")] 		public CEnum<ECurveInterpolationMode> PositionInterpolationMode { get; set;}

		[RED("positionManualMode")] 		public CEnum<ECurveManualMode> PositionManualMode { get; set;}

		[RED("rotationInterpolationMode")] 		public CEnum<ECurveInterpolationMode> RotationInterpolationMode { get; set;}

		[RED("totalTime")] 		public CFloat TotalTime { get; set;}

		[RED("automaticPositionInterpolationSmoothness")] 		public CFloat AutomaticPositionInterpolationSmoothness { get; set;}

		[RED("automaticRotationInterpolationSmoothness")] 		public CFloat AutomaticRotationInterpolationSmoothness { get; set;}

		[RED("enableConsistentNumberOfControlPoints")] 		public CBool EnableConsistentNumberOfControlPoints { get; set;}

		[RED("enableAutomaticTimeByDistanceRecalculation")] 		public CBool EnableAutomaticTimeByDistanceRecalculation { get; set;}

		[RED("enableAutomaticTimeRecalculation")] 		public CBool EnableAutomaticTimeRecalculation { get; set;}

		[RED("enableAutomaticRotationFromDirectionRecalculation")] 		public CBool EnableAutomaticRotationFromDirectionRecalculation { get; set;}

		[RED("curves", 2,0)] 		public CArray<SCurveData> Curves { get; set;}

		[RED("leftTangents", 142,0)] 		public CArray<Vector> LeftTangents { get; set;}

		[RED("rightTangents", 142,0)] 		public CArray<Vector> RightTangents { get; set;}

		[RED("easeParams", 2,0)] 		public CArray<SCurveEaseParam> EaseParams { get; set;}

		[RED("translationRelativeMode")] 		public CEnum<ECurveRelativeMode> TranslationRelativeMode { get; set;}

		[RED("rotationRelativeMode")] 		public CEnum<ECurveRelativeMode> RotationRelativeMode { get; set;}

		[RED("scaleRelativeMode")] 		public CEnum<ECurveRelativeMode> ScaleRelativeMode { get; set;}

		[RED("initialParentTransform")] 		public EngineTransform InitialParentTransform { get; set;}

		[RED("hasInitialParentTransform")] 		public CBool HasInitialParentTransform { get; set;}

		public SMultiCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMultiCurve(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}