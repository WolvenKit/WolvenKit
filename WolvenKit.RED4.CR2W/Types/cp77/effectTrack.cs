using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrack : effectTrackBase
	{
		[Ordinal(0)] [RED("items")] public CArray<CHandle<effectTrackItem>> Items { get; set; }

		public effectTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
