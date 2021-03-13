using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(19)] [RED("ownerGlobalId")] public worldGlobalNodeID OwnerGlobalId { get; set; }
		[Ordinal(20)] [RED("entityAttachDistance")] public CFloat EntityAttachDistance { get; set; }

		public worldEntityProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
