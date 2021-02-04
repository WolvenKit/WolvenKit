using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questMoveOnSpline_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(1)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(2)]  [RED("startFrom")] public CFloat StartFrom { get; set; }
		[Ordinal(3)]  [RED("blendType")] public CEnum<vehiclePlayerToAIInterpolationType> BlendType { get; set; }
		[Ordinal(4)]  [RED("blendTime")] public CFloat BlendTime { get; set; }
		[Ordinal(5)]  [RED("reverseGear")] public CBool ReverseGear { get; set; }
		[Ordinal(6)]  [RED("arriveWithPivot")] public CBool ArriveWithPivot { get; set; }
		[Ordinal(7)]  [RED("sceneBlendInDistance")] public CFloat SceneBlendInDistance { get; set; }
		[Ordinal(8)]  [RED("sceneBlendOutDistance")] public CFloat SceneBlendOutDistance { get; set; }
		[Ordinal(9)]  [RED("overrides")] public CHandle<questIVehicleMoveOnSpline_Overrides> Overrides { get; set; }
		[Ordinal(10)]  [RED("audioCurves")] public rRef<vehicleAudioVehicleCurveSet> AudioCurves { get; set; }

		public questMoveOnSpline_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
