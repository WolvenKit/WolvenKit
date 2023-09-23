using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardCaseContainer : gameContainerObjectSingleItem
	{
		[Ordinal(50)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("shardMesh")] 
		public CHandle<entMeshComponent> ShardMesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		public ShardCaseContainer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
