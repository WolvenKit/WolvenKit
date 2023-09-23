using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleRadioTierEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("radioTier")] 
		public CUInt32 RadioTier
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("overrideTier")] 
		public CBool OverrideTier
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleRadioTierEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
