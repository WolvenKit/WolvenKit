using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoWidget : inkLeafWidget
	{
		[Ordinal(20)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
		[Ordinal(21)] [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(22)] [RED("overriddenPlayerName")] public CName OverriddenPlayerName { get; set; }
		[Ordinal(23)] [RED("isParallaxEnabled")] public CBool IsParallaxEnabled { get; set; }
		[Ordinal(24)] [RED("prefetchVideo")] public CBool PrefetchVideo { get; set; }

		public inkVideoWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
