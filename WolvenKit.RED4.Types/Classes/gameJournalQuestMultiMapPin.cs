using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalQuestMultiMapPin : gameJournalQuestMapPinBase
	{
		[Ordinal(3)] 
		[RED("references")] 
		public CArray<NodeRef> References
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("mappinData")] 
		public gamemappinsMappinData MappinData
		{
			get => GetPropertyValue<gamemappinsMappinData>();
			set => SetPropertyValue<gamemappinsMappinData>(value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("uiAnimation")] 
		public TweakDBID UiAnimation
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameJournalQuestMultiMapPin()
		{
			Entries = new();
			EnableGPS = true;
			References = new();
			SlotName = "UI_Interaction";
			MappinData = new() { MappinType = 151509826449, Variant = Enums.gamedataMappinVariant.DefaultQuestVariant, Active = true, LocalizedCaption = new() { Unk1 = 0, Value = "" }, VisibleThroughWalls = true };
			Offset = new() { Z = 0.500000F };
		}
	}
}
