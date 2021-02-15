using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectDebugSettings : CVariable
	{
		[Ordinal(0)] [RED("overrideGlobalSettings")] public CBool OverrideGlobalSettings { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)] [RED("color")] public CColor Color { get; set; }

		public gameEffectDebugSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
