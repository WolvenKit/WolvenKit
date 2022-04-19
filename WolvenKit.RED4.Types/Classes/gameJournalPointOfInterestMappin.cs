using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalPointOfInterestMappin : gameJournalEntry
	{
		[Ordinal(1)] 
		[RED("staticNodeRef")] 
		public NodeRef StaticNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("dynamicEntityRef")] 
		public gameEntityReference DynamicEntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("securityAreaRef")] 
		public NodeRef SecurityAreaRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(4)] 
		[RED("mappinData")] 
		public gamemappinsPointOfInterestMappinData MappinData
		{
			get => GetPropertyValue<gamemappinsPointOfInterestMappinData>();
			set => SetPropertyValue<gamemappinsPointOfInterestMappinData>(value);
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("questPath")] 
		public CHandle<gameJournalPath> QuestPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(7)] 
		[RED("recommendedLevelID")] 
		public TweakDBID RecommendedLevelID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(8)] 
		[RED("notificationTriggerAreaRef")] 
		public NodeRef NotificationTriggerAreaRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gameJournalPointOfInterestMappin()
		{
			DynamicEntityRef = new() { Names = new() };
			MappinData = new() { Active = true };
			Offset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
