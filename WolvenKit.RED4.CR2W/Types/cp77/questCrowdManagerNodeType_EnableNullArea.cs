using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCrowdManagerNodeType_EnableNullArea : questICrowdManager_NodeType
	{
		[Ordinal(0)] [RED("areaReference")] public NodeRef AreaReference { get; set; }
		[Ordinal(1)] [RED("enable")] public CBool Enable { get; set; }

		public questCrowdManagerNodeType_EnableNullArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
