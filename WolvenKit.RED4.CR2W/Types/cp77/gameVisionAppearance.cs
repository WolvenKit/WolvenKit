using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionAppearance : CVariable
	{
		[Ordinal(0)] [RED("fill")] public CInt32 Fill { get; set; }
		[Ordinal(1)] [RED("outline")] public CInt32 Outline { get; set; }
		[Ordinal(2)] [RED("showThroughWalls")] public CBool ShowThroughWalls { get; set; }
		[Ordinal(3)] [RED("patternType")] public CEnum<gameVisionModePatternType> PatternType { get; set; }

		public gameVisionAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
