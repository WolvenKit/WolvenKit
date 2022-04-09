using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGenericNotificationViewData : IScriptable
	{
		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("soundAction")] 
		public CName SoundAction
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("action")] 
		public CHandle<GenericNotificationBaseAction> Action
		{
			get => GetPropertyValue<CHandle<GenericNotificationBaseAction>>();
			set => SetPropertyValue<CHandle<GenericNotificationBaseAction>>(value);
		}

		public gameuiGenericNotificationViewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
