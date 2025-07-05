using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SendSpiderbotToPerformActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public SendSpiderbotToPerformActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
