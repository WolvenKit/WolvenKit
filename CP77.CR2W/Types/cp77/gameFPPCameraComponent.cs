using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFPPCameraComponent : gameCameraComponent
	{
		[Ordinal(0)]  [RED("pitchMin")] public CFloat PitchMin { get; set; }
		[Ordinal(1)]  [RED("pitchMax")] public CFloat PitchMax { get; set; }
		[Ordinal(2)]  [RED("yawMaxLeft")] public CFloat YawMaxLeft { get; set; }
		[Ordinal(3)]  [RED("yawMaxRight")] public CFloat YawMaxRight { get; set; }
		[Ordinal(4)]  [RED("headingLocked")] public CBool HeadingLocked { get; set; }
		[Ordinal(5)]  [RED("sensitivityMultX")] public CFloat SensitivityMultX { get; set; }
		[Ordinal(6)]  [RED("sensitivityMultY")] public CFloat SensitivityMultY { get; set; }
		[Ordinal(7)]  [RED("timeDilationCurveName")] public CName TimeDilationCurveName { get; set; }

		public gameFPPCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
