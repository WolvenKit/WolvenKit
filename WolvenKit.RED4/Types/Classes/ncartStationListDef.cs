using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ncartStationListDef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("station")] 
		public CEnum<ENcartStations> Station
		{
			get => GetPropertyValue<CEnum<ENcartStations>>();
			set => SetPropertyValue<CEnum<ENcartStations>>(value);
		}

		public ncartStationListDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
