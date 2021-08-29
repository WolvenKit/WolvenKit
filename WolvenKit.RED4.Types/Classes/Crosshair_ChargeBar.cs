using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Crosshair_ChargeBar : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _bar;
		private inkTextWidgetReference _ammo;
		private CWeakHandle<inkWidget> _leftPart;
		private CWeakHandle<inkWidget> _rightPart;
		private CWeakHandle<inkWidget> _topPart;
		private CWeakHandle<inkRectangleWidget> _chargeBar;
		private Vector2 _sizeOfChargeBar;
		private CHandle<redCallbackObject> _chargeBBID;

		[Ordinal(18)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(19)] 
		[RED("ammo")] 
		public inkTextWidgetReference Ammo
		{
			get => GetProperty(ref _ammo);
			set => SetProperty(ref _ammo, value);
		}

		[Ordinal(20)] 
		[RED("leftPart")] 
		public CWeakHandle<inkWidget> LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(21)] 
		[RED("rightPart")] 
		public CWeakHandle<inkWidget> RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(22)] 
		[RED("topPart")] 
		public CWeakHandle<inkWidget> TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(23)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkRectangleWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(24)] 
		[RED("sizeOfChargeBar")] 
		public Vector2 SizeOfChargeBar
		{
			get => GetProperty(ref _sizeOfChargeBar);
			set => SetProperty(ref _sizeOfChargeBar, value);
		}

		[Ordinal(25)] 
		[RED("chargeBBID")] 
		public CHandle<redCallbackObject> ChargeBBID
		{
			get => GetProperty(ref _chargeBBID);
			set => SetProperty(ref _chargeBBID, value);
		}
	}
}
