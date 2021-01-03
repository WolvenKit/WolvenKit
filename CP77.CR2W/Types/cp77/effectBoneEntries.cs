using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectBoneEntries : effectIPlacementEntries
	{
		[Ordinal(0)]  [RED("bones")] public CArray<effectBoneEntry> Bones { get; set; }
		[Ordinal(1)]  [RED("inheritRotation")] public CBool InheritRotation { get; set; }

		public effectBoneEntries(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
