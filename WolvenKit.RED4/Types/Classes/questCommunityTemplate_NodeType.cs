using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCommunityTemplate_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("communityEntryName")] 
		public CName CommunityEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("communityEntryPhaseName")] 
		public CName CommunityEntryPhaseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questCommunityTemplate_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
