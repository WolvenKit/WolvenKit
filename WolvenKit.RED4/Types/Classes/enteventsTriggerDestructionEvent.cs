using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class enteventsTriggerDestructionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("velocity")] 
		public CFloat Velocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public enteventsTriggerDestructionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
