using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawner_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}
	}
}
