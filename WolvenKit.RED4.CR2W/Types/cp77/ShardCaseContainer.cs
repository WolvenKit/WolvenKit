using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCaseContainer : gameContainerObjectSingleItem
	{
		private CBool _wasOpened;
		private CHandle<entMeshComponent> _shardMesh;

		[Ordinal(52)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get => GetProperty(ref _wasOpened);
			set => SetProperty(ref _wasOpened, value);
		}

		[Ordinal(53)] 
		[RED("shardMesh")] 
		public CHandle<entMeshComponent> ShardMesh
		{
			get => GetProperty(ref _shardMesh);
			set => SetProperty(ref _shardMesh, value);
		}

		public ShardCaseContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
