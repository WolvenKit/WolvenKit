using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectBoneEntries : effectIPlacementEntries
	{
		[Ordinal(0)] [RED("inheritRotation")] public CBool InheritRotation { get; set; }
		[Ordinal(1)] [RED("bones")] public CArray<effectBoneEntry> Bones { get; set; }

		public effectBoneEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
