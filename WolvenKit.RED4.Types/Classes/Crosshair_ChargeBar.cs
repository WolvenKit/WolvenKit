using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_ChargeBar : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("ammo")] 
		public inkTextWidgetReference Ammo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("leftPart")] 
		public CWeakHandle<inkWidget> LeftPart
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("rightPart")] 
		public CWeakHandle<inkWidget> RightPart
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("topPart")] 
		public CWeakHandle<inkWidget> TopPart
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkRectangleWidget> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("sizeOfChargeBar")] 
		public Vector2 SizeOfChargeBar
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(25)] 
		[RED("chargeBBID")] 
		public CHandle<redCallbackObject> ChargeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public Crosshair_ChargeBar()
		{
			Bar = new();
			Ammo = new();
			SizeOfChargeBar = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
