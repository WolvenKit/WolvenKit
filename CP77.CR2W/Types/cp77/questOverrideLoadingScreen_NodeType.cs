using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questOverrideLoadingScreen_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("forceVideoFrameRate")] public CBool ForceVideoFrameRate { get; set; }
		[Ordinal(1)]  [RED("glitchEffectTime")] public CFloat GlitchEffectTime { get; set; }
		[Ordinal(2)]  [RED("keepLoadingScreenWhileVideoIsPlaying")] public CBool KeepLoadingScreenWhileVideoIsPlaying { get; set; }
		[Ordinal(3)]  [RED("minimumPlayCount")] public CUInt32 MinimumPlayCount { get; set; }
		[Ordinal(4)]  [RED("tooltipDuration")] public CFloat TooltipDuration { get; set; }
		[Ordinal(5)]  [RED("tooltips")] public CArray<CString> Tooltips { get; set; }
		[Ordinal(6)]  [RED("video")] public raRef<Bink> Video { get; set; }
		[Ordinal(7)]  [RED("videos")] public CArray<raRef<Bink>> Videos { get; set; }

		public questOverrideLoadingScreen_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
