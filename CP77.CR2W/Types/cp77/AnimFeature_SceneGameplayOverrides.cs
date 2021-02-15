using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SceneGameplayOverrides : animAnimFeature
	{
		[Ordinal(0)] [RED("aimForced")] public CBool AimForced { get; set; }
		[Ordinal(1)] [RED("safeForced")] public CBool SafeForced { get; set; }
		[Ordinal(2)] [RED("isAimOutTimeOverridden")] public CBool IsAimOutTimeOverridden { get; set; }
		[Ordinal(3)] [RED("aimOutTimeOverride")] public CFloat AimOutTimeOverride { get; set; }

		public AnimFeature_SceneGameplayOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
