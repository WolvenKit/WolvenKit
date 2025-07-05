using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiProgressionViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] 
		[RED("expValue")] 
		public CInt32 ExpValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("expProgress")] 
		public CFloat ExpProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("delta")] 
		public CInt32 Delta
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("notificationColorTheme")] 
		public CName NotificationColorTheme
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("canBeMerged")] 
		public CBool CanBeMerged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("isLevelMaxed")] 
		public CBool IsLevelMaxed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("type")] 
		public CEnum<gamedataProficiencyType> Type
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		public gameuiProgressionViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
