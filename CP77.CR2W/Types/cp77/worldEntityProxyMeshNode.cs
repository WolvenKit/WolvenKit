using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldEntityProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(0)]  [RED("entityAttachDistance")] public CFloat EntityAttachDistance { get; set; }
		[Ordinal(1)]  [RED("ownerGlobalId")] public worldGlobalNodeID OwnerGlobalId { get; set; }

		public worldEntityProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
