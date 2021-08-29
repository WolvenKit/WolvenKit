using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardCaseContainer : gameContainerObjectSingleItem
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
	}
}
