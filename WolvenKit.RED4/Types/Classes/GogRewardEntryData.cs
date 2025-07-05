using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRewardEntryData : IScriptable
	{
		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("group")] 
		public CName Group
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("slotType")] 
		public CName SlotType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("record")] 
		public CWeakHandle<gamedataGOGReward_Record> Record
		{
			get => GetPropertyValue<CWeakHandle<gamedataGOGReward_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataGOGReward_Record>>(value);
		}

		public GogRewardEntryData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
