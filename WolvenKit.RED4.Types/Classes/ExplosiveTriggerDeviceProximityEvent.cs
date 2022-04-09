using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveTriggerDeviceProximityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("instigator")] 
		public entEntityID Instigator
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ExplosiveTriggerDeviceProximityEvent()
		{
			Instigator = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
