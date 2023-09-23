using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_Tech_Omaha : gameuiCrosshairBaseGameController
	{
		[Ordinal(27)] 
		[RED("leftPart")] 
		public CWeakHandle<inkWidget> LeftPart
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("rightPart")] 
		public CWeakHandle<inkWidget> RightPart
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(29)] 
		[RED("topPart")] 
		public CWeakHandle<inkWidget> TopPart
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(30)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkRectangleWidget> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(31)] 
		[RED("sizeOfChargeBar")] 
		public Vector2 SizeOfChargeBar
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(32)] 
		[RED("chargeBBID")] 
		public CHandle<redCallbackObject> ChargeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public Crosshair_Tech_Omaha()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
