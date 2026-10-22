using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityCommunityTemplate : CResource
	{
		[Ordinal(1)] 
		[RED("communityTemplate")] 
		public CHandle<communityCommunityTemplateData> CommunityTemplate
		{
			get => GetPropertyValue<CHandle<communityCommunityTemplateData>>();
			set => SetPropertyValue<CHandle<communityCommunityTemplateData>>(value);
		}

		public communityCommunityTemplate()
		{
			CommunityTemplate = new communityCommunityTemplateData { Entries = new() { new communitySpawnEntry { Phases = new() { new communitySpawnPhase() } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
