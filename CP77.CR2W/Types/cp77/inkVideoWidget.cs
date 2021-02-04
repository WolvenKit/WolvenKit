using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkVideoWidget : inkLeafWidget
	{
		[Ordinal(0)]  [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
		[Ordinal(1)]  [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(2)]  [RED("overriddenPlayerName")] public CName OverriddenPlayerName { get; set; }
		[Ordinal(3)]  [RED("isParallaxEnabled")] public CBool IsParallaxEnabled { get; set; }
		[Ordinal(4)]  [RED("prefetchVideo")] public CBool PrefetchVideo { get; set; }

		public inkVideoWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
