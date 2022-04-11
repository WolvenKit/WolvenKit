using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCDebugInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spawnerID")] 
		public entEntityID SpawnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("communityName")] 
		public CName CommunityName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("characterRecord")] 
		public CHandle<gamedataCharacter_Record> CharacterRecord
		{
			get => GetPropertyValue<CHandle<gamedataCharacter_Record>>();
			set => SetPropertyValue<CHandle<gamedataCharacter_Record>>(value);
		}

		public NPCDebugInfo()
		{
			SpawnerID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
