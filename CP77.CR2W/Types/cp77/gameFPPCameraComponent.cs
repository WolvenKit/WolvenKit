using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFPPCameraComponent : gameCameraComponent
	{
		[Ordinal(35)] [RED("pitchMin")] public CFloat PitchMin { get; set; }
		[Ordinal(36)] [RED("pitchMax")] public CFloat PitchMax { get; set; }
		[Ordinal(37)] [RED("yawMaxLeft")] public CFloat YawMaxLeft { get; set; }
		[Ordinal(38)] [RED("yawMaxRight")] public CFloat YawMaxRight { get; set; }
		[Ordinal(39)] [RED("headingLocked")] public CBool HeadingLocked { get; set; }
		[Ordinal(40)] [RED("sensitivityMultX")] public CFloat SensitivityMultX { get; set; }
		[Ordinal(41)] [RED("sensitivityMultY")] public CFloat SensitivityMultY { get; set; }
		[Ordinal(42)] [RED("timeDilationCurveName")] public CName TimeDilationCurveName { get; set; }

		public gameFPPCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
