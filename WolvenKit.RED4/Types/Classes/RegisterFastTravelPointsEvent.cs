using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterFastTravelPointsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("fastTravelNodes")] 
		public CArray<CHandle<gameFastTravelPointData>> FastTravelNodes
		{
			get => GetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>();
			set => SetPropertyValue<CArray<CHandle<gameFastTravelPointData>>>(value);
		}

		public RegisterFastTravelPointsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
