using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionAdjuster : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("targetPosition")] public animVectorLink TargetPosition { get; set; }
		[Ordinal(3)] [RED("targetDirection")] public animVectorLink TargetDirection { get; set; }
		[Ordinal(4)] [RED("initialForwardVector")] public Vector4 InitialForwardVector { get; set; }
		[Ordinal(5)] [RED("blendSpeedPos")] public CFloat BlendSpeedPos { get; set; }
		[Ordinal(6)] [RED("blendSpeedPosMin")] public CFloat BlendSpeedPosMin { get; set; }
		[Ordinal(7)] [RED("blendSpeedRot")] public CFloat BlendSpeedRot { get; set; }
		[Ordinal(8)] [RED("maxDistance")] public CFloat MaxDistance { get; set; }

		public animAnimNode_LocomotionAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
