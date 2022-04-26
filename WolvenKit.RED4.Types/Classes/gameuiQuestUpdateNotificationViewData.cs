using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiQuestUpdateNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("questEntryId")] 
		public CString QuestEntryId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("SMSText")] 
		public CString SMSText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("dontRemoveOnRequest")] 
		public CBool DontRemoveOnRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("rewardSC")] 
		public CInt32 RewardSC
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("rewardXP")] 
		public CInt32 RewardXP
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("priority")] 
		public CEnum<EGenericNotificationPriority> Priority
		{
			get => GetPropertyValue<CEnum<EGenericNotificationPriority>>();
			set => SetPropertyValue<CEnum<EGenericNotificationPriority>>(value);
		}

		public gameuiQuestUpdateNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
