using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSpawnerNotReady_ConditionType : questISpawnerConditionType
	{
		[Ordinal(0)] 
		[RED("spawnerReference")] 
		public NodeRef SpawnerReference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("communityEntryNames")] 
		public CArray<CName> CommunityEntryNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public questSpawnerNotReady_ConditionType()
		{
			CommunityEntryNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
