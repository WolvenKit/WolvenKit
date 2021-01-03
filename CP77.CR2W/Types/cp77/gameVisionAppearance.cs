using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVisionAppearance : CVariable
	{
		[Ordinal(0)]  [RED("fill")] public CInt32 Fill { get; set; }
		[Ordinal(1)]  [RED("outline")] public CInt32 Outline { get; set; }
		[Ordinal(2)]  [RED("patternType")] public CEnum<gameVisionModePatternType> PatternType { get; set; }
		[Ordinal(3)]  [RED("showThroughWalls")] public CBool ShowThroughWalls { get; set; }

		public gameVisionAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
