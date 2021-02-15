using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HighlightEditableData : IScriptable
	{
		[Ordinal(0)] [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }
		[Ordinal(1)] [RED("outlineType")] public CEnum<EFocusOutlineType> OutlineType { get; set; }
		[Ordinal(2)] [RED("priority")] public CEnum<EPriority> Priority { get; set; }
		[Ordinal(3)] [RED("inTransitionTime")] public CFloat InTransitionTime { get; set; }
		[Ordinal(4)] [RED("outTransitionTime")] public CFloat OutTransitionTime { get; set; }
		[Ordinal(5)] [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(6)] [RED("patternType")] public CEnum<gameVisionModePatternType> PatternType { get; set; }

		public HighlightEditableData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
