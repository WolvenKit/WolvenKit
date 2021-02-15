using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTier3CameraSettings : CVariable
	{
		[Ordinal(0)] [RED("yawLeftLimit")] public CFloat YawLeftLimit { get; set; }
		[Ordinal(1)] [RED("yawRightLimit")] public CFloat YawRightLimit { get; set; }
		[Ordinal(2)] [RED("pitchTopLimit")] public CFloat PitchTopLimit { get; set; }
		[Ordinal(3)] [RED("pitchBottomLimit")] public CFloat PitchBottomLimit { get; set; }
		[Ordinal(4)] [RED("pitchSpeedMultiplier")] public CFloat PitchSpeedMultiplier { get; set; }
		[Ordinal(5)] [RED("yawSpeedMultiplier")] public CFloat YawSpeedMultiplier { get; set; }

		public gameTier3CameraSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
