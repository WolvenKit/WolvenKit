using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalPointOfInterestMappin : gameJournalEntry
	{
		[Ordinal(2)] 
		[RED("staticNodeRef")] 
		public NodeRef StaticNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("dynamicEntityRef")] 
		public gameEntityReference DynamicEntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(4)] 
		[RED("securityAreaRef")] 
		public NodeRef SecurityAreaRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("mappinData")] 
		public gamemappinsPointOfInterestMappinData MappinData
		{
			get => GetPropertyValue<gamemappinsPointOfInterestMappinData>();
			set => SetPropertyValue<gamemappinsPointOfInterestMappinData>(value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("questPath")] 
		public CHandle<gameJournalPath> QuestPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(8)] 
		[RED("recommendedLevelID")] 
		public TweakDBID RecommendedLevelID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("notificationTriggerAreaRef")] 
		public NodeRef NotificationTriggerAreaRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gameJournalPointOfInterestMappin()
		{
			JournalEntryOverrideDataList = new();
			DynamicEntityRef = new gameEntityReference { Names = new() };
			MappinData = new gamemappinsPointOfInterestMappinData { Active = true, SlotName = "UI_Interaction", SlotOffset = new Vector3 { Z = 0.500000F }, DynamicMappinRadius = 30.000000F, StaticMappinDef = 196254225639, DynamicMappinDef = 201635944716 };
			Offset = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
