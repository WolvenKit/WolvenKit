using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCommunitySpawnSetNameToID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<gameCommunitySpawnSetNameToIDEntry> Entries
		{
			get => GetPropertyValue<CArray<gameCommunitySpawnSetNameToIDEntry>>();
			set => SetPropertyValue<CArray<gameCommunitySpawnSetNameToIDEntry>>(value);
		}

		public gameCommunitySpawnSetNameToID()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
