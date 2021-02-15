using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeActionLocomotionParameters : IScriptable
	{
		[Ordinal(0)] [RED("imperfectTurn")] public CBool ImperfectTurn { get; set; }
		[Ordinal(1)] [RED("speedBoostInputRequired")] public CBool SpeedBoostInputRequired { get; set; }
		[Ordinal(2)] [RED("speedBoostMultiplyByDot")] public CBool SpeedBoostMultiplyByDot { get; set; }
		[Ordinal(3)] [RED("useCameraHeadingForMovement")] public CBool UseCameraHeadingForMovement { get; set; }
		[Ordinal(4)] [RED("validImperfectTurn")] public CBool ValidImperfectTurn { get; set; }
		[Ordinal(5)] [RED("validSpeedBoostInputRequired")] public CBool ValidSpeedBoostInputRequired { get; set; }
		[Ordinal(6)] [RED("validSpeedBoostMultiplyByDot")] public CBool ValidSpeedBoostMultiplyByDot { get; set; }
		[Ordinal(7)] [RED("validUseCameraHeadingForMovement")] public CBool ValidUseCameraHeadingForMovement { get; set; }
		[Ordinal(8)] [RED("doJump")] public CBool DoJump { get; set; }
		[Ordinal(9)] [RED("doSpeedBoost")] public CBool DoSpeedBoost { get; set; }

		public gamestateMachineparameterTypeActionLocomotionParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
