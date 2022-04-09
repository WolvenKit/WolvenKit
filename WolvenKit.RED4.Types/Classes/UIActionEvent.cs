using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetPropertyValue<CHandle<gamedeviceAction>>();
			set => SetPropertyValue<CHandle<gamedeviceAction>>(value);
		}

		[Ordinal(1)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public UIActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
