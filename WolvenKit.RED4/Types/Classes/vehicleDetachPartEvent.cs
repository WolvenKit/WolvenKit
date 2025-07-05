using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleDetachPartEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public vehicleDetachPartEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
