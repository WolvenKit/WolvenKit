using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleQuestDelayedHornEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("honkTime")] 
		public CFloat HonkTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public VehicleQuestDelayedHornEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
