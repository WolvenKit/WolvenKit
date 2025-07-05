using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityCommunityTemplateData : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<CHandle<communitySpawnEntry>> Entries
		{
			get => GetPropertyValue<CArray<CHandle<communitySpawnEntry>>>();
			set => SetPropertyValue<CArray<CHandle<communitySpawnEntry>>>(value);
		}

		[Ordinal(1)] 
		[RED("crowdEntries")] 
		public CArray<gameCrowdTemplateEntry> CrowdEntries
		{
			get => GetPropertyValue<CArray<gameCrowdTemplateEntry>>();
			set => SetPropertyValue<CArray<gameCrowdTemplateEntry>>(value);
		}

		[Ordinal(2)] 
		[RED("spawnSetReference")] 
		public CName SpawnSetReference
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public communityCommunityTemplateData()
		{
			Entries = new() { null };
			CrowdEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
