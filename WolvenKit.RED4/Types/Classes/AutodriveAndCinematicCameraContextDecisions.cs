using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AutodriveAndCinematicCameraContextDecisions : InputContextTransitionDecisions
	{
		[Ordinal(0)] 
		[RED("autodriveCallbackID")] 
		public CHandle<redCallbackObject> AutodriveCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(1)] 
		[RED("cinematicCameraCallbackID")] 
		public CHandle<redCallbackObject> CinematicCameraCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(2)] 
		[RED("delamainTaxiCallbackID")] 
		public CHandle<redCallbackObject> DelamainTaxiCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("autodriveEnabled")] 
		public CBool AutodriveEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("cinematicCameraActive")] 
		public CBool CinematicCameraActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("delamainTaxi")] 
		public CBool DelamainTaxi
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AutodriveAndCinematicCameraContextDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
