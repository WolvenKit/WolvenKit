using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCReference : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("communitySpawner")] 
		public NodeRef CommunitySpawner
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("entryName")] 
		public CName EntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public NPCReference()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
