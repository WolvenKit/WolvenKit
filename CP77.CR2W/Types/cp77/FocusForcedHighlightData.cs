using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FocusForcedHighlightData : IScriptable
	{
		[Ordinal(0)]  [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }
		[Ordinal(1)]  [RED("hudData")] public CHandle<HighlightInstance> HudData { get; set; }
		[Ordinal(2)]  [RED("inTransitionTime")] public CFloat InTransitionTime { get; set; }
		[Ordinal(3)]  [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(4)]  [RED("isSavable")] public CBool IsSavable { get; set; }
		[Ordinal(5)]  [RED("outTransitionTime")] public CFloat OutTransitionTime { get; set; }
		[Ordinal(6)]  [RED("outlineType")] public CEnum<EFocusOutlineType> OutlineType { get; set; }
		[Ordinal(7)]  [RED("patternType")] public CEnum<gameVisionModePatternType> PatternType { get; set; }
		[Ordinal(8)]  [RED("priority")] public CEnum<EPriority> Priority { get; set; }
		[Ordinal(9)]  [RED("sourceID")] public entEntityID SourceID { get; set; }
		[Ordinal(10)]  [RED("sourceName")] public CName SourceName { get; set; }

		public FocusForcedHighlightData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
