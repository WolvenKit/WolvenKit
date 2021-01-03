using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ShardCaseContainer : gameContainerObjectSingleItem
	{
		[Ordinal(0)]  [RED("shardMesh")] public CHandle<entMeshComponent> ShardMesh { get; set; }
		[Ordinal(1)]  [RED("wasOpened")] public CBool WasOpened { get; set; }

		public ShardCaseContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
