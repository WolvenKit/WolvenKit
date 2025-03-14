using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestMultiMapPin : gameJournalQuestMapPinBase
	{
		[Ordinal(4)] 
		[RED("references")] 
		public CArray<NodeRef> References
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(5)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("mappinData")] 
		public gamemappinsMappinData MappinData
		{
			get => GetPropertyValue<gamemappinsMappinData>();
			set => SetPropertyValue<gamemappinsMappinData>(value);
		}

		[Ordinal(7)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("uiAnimation")] 
		public TweakDBID UiAnimation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameJournalQuestMultiMapPin()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			EnableGPS = true;
			References = new();
			SlotName = "UI_Interaction";
			MappinData = new gamemappinsMappinData { MappinType = "Mappins.QuestStaticMappinDefinition", Variant = Enums.gamedataMappinVariant.DefaultQuestVariant, Active = true, LocalizedCaption = new() { Unk1 = 0, Value = "" }, VisibleThroughWalls = true };
			Offset = new Vector3 { Z = 0.500000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
