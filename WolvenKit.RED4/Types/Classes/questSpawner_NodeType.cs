using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSpawner_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public questSpawner_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
