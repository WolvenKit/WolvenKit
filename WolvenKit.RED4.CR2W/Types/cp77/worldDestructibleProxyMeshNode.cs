using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDestructibleProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(19)] [RED("ownerHash")] public CUInt64 OwnerHash { get; set; }

		public worldDestructibleProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
