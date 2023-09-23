using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelDeviceAction : ActionBool
	{
		[Ordinal(38)] 
		[RED("fastTravelPointData")] 
		public CHandle<gameFastTravelPointData> FastTravelPointData
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		public FastTravelDeviceAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
