using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayLibraryAnimationButtonView : BaseButtonView
	{
		[Ordinal(0)]  [RED("InputAnimation")] public CHandle<inkanimProxy> InputAnimation { get; set; }
		[Ordinal(1)]  [RED("ToDefaultAnimationName")] public CName ToDefaultAnimationName { get; set; }
		[Ordinal(2)]  [RED("ToDisabledAnimationName")] public CName ToDisabledAnimationName { get; set; }
		[Ordinal(3)]  [RED("ToHoverAnimationName")] public CName ToHoverAnimationName { get; set; }
		[Ordinal(4)]  [RED("ToPressedAnimationName")] public CName ToPressedAnimationName { get; set; }

		public PlayLibraryAnimationButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
