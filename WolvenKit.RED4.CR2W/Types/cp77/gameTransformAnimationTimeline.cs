using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationTimeline : CVariable
	{
		[Ordinal(0)] [RED("items")] public CArray<gameTransformAnimationTrackItem> Items { get; set; }

		public gameTransformAnimationTimeline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
