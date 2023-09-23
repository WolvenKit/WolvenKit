using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelButtonLogicController : inkButtonController
	{
		[Ordinal(13)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("locationName")] 
		public inkTextWidgetReference LocationName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("soundData")] 
		public SSoundData SoundData
		{
			get => GetPropertyValue<SSoundData>();
			set => SetPropertyValue<SSoundData>(value);
		}

		[Ordinal(16)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("fastTravelPointData")] 
		public CWeakHandle<gameFastTravelPointData> FastTravelPointData
		{
			get => GetPropertyValue<CWeakHandle<gameFastTravelPointData>>();
			set => SetPropertyValue<CWeakHandle<gameFastTravelPointData>>(value);
		}

		public FastTravelButtonLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
