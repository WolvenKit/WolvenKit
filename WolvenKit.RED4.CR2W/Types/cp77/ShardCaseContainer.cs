using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCaseContainer : gameContainerObjectSingleItem
	{
		[Ordinal(52)] [RED("wasOpened")] public CBool WasOpened { get; set; }
		[Ordinal(53)] [RED("shardMesh")] public CHandle<entMeshComponent> ShardMesh { get; set; }

		public ShardCaseContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
