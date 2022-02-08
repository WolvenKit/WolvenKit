using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardCaseContainer : gameContainerObjectSingleItem
	{
		[Ordinal(52)] 
		[RED("wasOpened")] 
		public CBool WasOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("shardMesh")] 
		public CHandle<entMeshComponent> ShardMesh
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}
	}
}
