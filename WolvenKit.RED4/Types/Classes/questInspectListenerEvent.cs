using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInspectListenerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<questObjectInspectListener> Listener
		{
			get => GetPropertyValue<CHandle<questObjectInspectListener>>();
			set => SetPropertyValue<CHandle<questObjectInspectListener>>(value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questInspectListenerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
