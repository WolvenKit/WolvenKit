using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackGroup : effectTrackBase
	{
		[Ordinal(0)] [RED("tracks")] public CArray<CHandle<effectTrackBase>> Tracks { get; set; }
		[Ordinal(1)] [RED("componentName")] public CName ComponentName { get; set; }

		public effectTrackGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
