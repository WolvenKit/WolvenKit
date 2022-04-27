using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetDetectionMultiplier : redEvent
	{
		[Ordinal(0)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SetDetectionMultiplier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
