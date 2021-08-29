using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawner_NodeType : questSpawnManagerNodeType
	{
		private NodeRef _spawnerReference;

		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetProperty(ref _spawnerReference);
			set => SetProperty(ref _spawnerReference, value);
		}
	}
}
