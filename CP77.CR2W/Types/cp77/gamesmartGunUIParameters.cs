using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUIParameters : IScriptable
	{
		[Ordinal(0)] [RED("targets")] public CArray<gamesmartGunUITargetParameters> Targets { get; set; }
		[Ordinal(1)] [RED("sight")] public gamesmartGunUISightParameters Sight { get; set; }
		[Ordinal(2)] [RED("crosshairPos")] public Vector2 CrosshairPos { get; set; }
		[Ordinal(3)] [RED("hasRequiredCyberware")] public CBool HasRequiredCyberware { get; set; }
		[Ordinal(4)] [RED("timeToRemoveOccludedTarget")] public CFloat TimeToRemoveOccludedTarget { get; set; }
		[Ordinal(5)] [RED("timeToLock")] public CFloat TimeToLock { get; set; }
		[Ordinal(6)] [RED("timeToUnlock")] public CFloat TimeToUnlock { get; set; }

		public gamesmartGunUIParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
