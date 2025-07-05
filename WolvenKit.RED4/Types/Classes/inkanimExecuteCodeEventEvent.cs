using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimExecuteCodeEventEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("eventToExecute")] 
		public CHandle<redEvent> EventToExecute
		{
			get => GetPropertyValue<CHandle<redEvent>>();
			set => SetPropertyValue<CHandle<redEvent>>(value);
		}

		public inkanimExecuteCodeEventEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
