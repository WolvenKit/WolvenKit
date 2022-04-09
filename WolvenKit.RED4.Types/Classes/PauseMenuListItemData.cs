using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PauseMenuListItemData : ListItemData
	{
		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<PauseMenuAction> Action
		{
			get => GetPropertyValue<CEnum<PauseMenuAction>>();
			set => SetPropertyValue<CEnum<PauseMenuAction>>(value);
		}

		public PauseMenuListItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
