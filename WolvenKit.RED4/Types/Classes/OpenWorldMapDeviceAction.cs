using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenWorldMapDeviceAction : ActionBool
	{
		[Ordinal(38)] 
		[RED("fastTravelPointData")] 
		public CHandle<gameFastTravelPointData> FastTravelPointData
		{
			get => GetPropertyValue<CHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CHandle<gameFastTravelPointData>>(value);
		}

		public OpenWorldMapDeviceAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
