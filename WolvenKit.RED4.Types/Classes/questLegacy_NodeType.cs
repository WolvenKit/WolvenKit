using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLegacy_NodeType : questSpawnManagerNodeType
	{
		private NodeRef _spawnerReference;
		private CName _communityEntryName;
		private CName _communityEntryPhaseName;

		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetProperty(ref _spawnerReference);
			set => SetProperty(ref _spawnerReference, value);
		}

		[Ordinal(2)] 
		[RED("communityEntryName")] 
		public CName CommunityEntryName
		{
			get => GetProperty(ref _communityEntryName);
			set => SetProperty(ref _communityEntryName, value);
		}

		[Ordinal(3)] 
		[RED("communityEntryPhaseName")] 
		public CName CommunityEntryPhaseName
		{
			get => GetProperty(ref _communityEntryPhaseName);
			set => SetProperty(ref _communityEntryPhaseName, value);
		}
	}
}
