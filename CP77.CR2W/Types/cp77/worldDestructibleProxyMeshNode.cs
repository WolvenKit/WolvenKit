using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldDestructibleProxyMeshNode : worldPrefabProxyMeshNode
	{
		[Ordinal(0)]  [RED("ownerHash")] public CUInt64 OwnerHash { get; set; }

		public worldDestructibleProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
