using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalQuestMapPin : gameJournalQuestMapPinBase
	{
		[Ordinal(4)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
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

		public gameJournalQuestMapPin()
		{
			JournalEntryOverrideDataList = new();
			Entries = new();
			EnableGPS = true;
			Reference = new gameEntityReference { Names = new() };
			SlotName = "UI_Interaction";
			MappinData = new gamemappinsMappinData { MappinType = 151509826449, Variant = Enums.gamedataMappinVariant.DefaultQuestVariant, Active = true, LocalizedCaption = new() { Unk1 = 0, Value = "" }, VisibleThroughWalls = true };
			Offset = new Vector3 { Z = 0.500000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
