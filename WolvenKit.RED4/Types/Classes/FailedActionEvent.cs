using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FailedActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetPropertyValue<CHandle<gamedeviceAction>>();
			set => SetPropertyValue<CHandle<gamedeviceAction>>(value);
		}

		[Ordinal(1)] 
		[RED("whoFailed")] 
		public gamePersistentID WhoFailed
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		public FailedActionEvent()
		{
			WhoFailed = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
