using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectRootEntries : effectIPlacementEntries
	{
		[Ordinal(0)] [RED("inheritRotation")] public CBool InheritRotation { get; set; }
		[Ordinal(1)] [RED("roots")] public CArray<effectRootEntry> Roots { get; set; }

		public effectRootEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
