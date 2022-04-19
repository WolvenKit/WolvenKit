using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleDestructionGridCell : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("impactEvent")] 
		public CName ImpactEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("impactDetailEvent")] 
		public CName ImpactDetailEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioVehicleDestructionGridCell()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
