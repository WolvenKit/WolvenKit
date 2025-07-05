using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleHornProbsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("honkMinTime")] 
		public CFloat HonkMinTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("honkMaxTime")] 
		public CFloat HonkMaxTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public VehicleHornProbsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
