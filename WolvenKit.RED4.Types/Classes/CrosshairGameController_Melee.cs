using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairGameController_Melee : gameuiCrosshairBaseMelee
	{
		private inkWidgetReference _targetColorChange;
		private CWeakHandle<inkCanvasWidget> _chargeBar;
		private CWeakHandle<inkRectangleWidget> _chargeBarFG;
		private CWeakHandle<inkImageWidget> _chargeBarMonoTop;
		private CWeakHandle<inkImageWidget> _chargeBarMonoBottom;
		private CWeakHandle<inkMaskWidget> _chargeBarMask;
		private CWeakHandle<inkTextWidget> _chargeValueL;
		private CWeakHandle<inkTextWidget> _chargeValueR;
		private CUInt32 _bbcharge;
		private CHandle<MeleeResourcePoolListener> _meleeResourcePoolListener;
		private entEntityID _weaponID;
		private CBool _displayChargeBar;

		[Ordinal(20)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(21)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkCanvasWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(22)] 
		[RED("chargeBarFG")] 
		public CWeakHandle<inkRectangleWidget> ChargeBarFG
		{
			get => GetProperty(ref _chargeBarFG);
			set => SetProperty(ref _chargeBarFG, value);
		}

		[Ordinal(23)] 
		[RED("chargeBarMonoTop")] 
		public CWeakHandle<inkImageWidget> ChargeBarMonoTop
		{
			get => GetProperty(ref _chargeBarMonoTop);
			set => SetProperty(ref _chargeBarMonoTop, value);
		}

		[Ordinal(24)] 
		[RED("chargeBarMonoBottom")] 
		public CWeakHandle<inkImageWidget> ChargeBarMonoBottom
		{
			get => GetProperty(ref _chargeBarMonoBottom);
			set => SetProperty(ref _chargeBarMonoBottom, value);
		}

		[Ordinal(25)] 
		[RED("chargeBarMask")] 
		public CWeakHandle<inkMaskWidget> ChargeBarMask
		{
			get => GetProperty(ref _chargeBarMask);
			set => SetProperty(ref _chargeBarMask, value);
		}

		[Ordinal(26)] 
		[RED("chargeValueL")] 
		public CWeakHandle<inkTextWidget> ChargeValueL
		{
			get => GetProperty(ref _chargeValueL);
			set => SetProperty(ref _chargeValueL, value);
		}

		[Ordinal(27)] 
		[RED("chargeValueR")] 
		public CWeakHandle<inkTextWidget> ChargeValueR
		{
			get => GetProperty(ref _chargeValueR);
			set => SetProperty(ref _chargeValueR, value);
		}

		[Ordinal(28)] 
		[RED("bbcharge")] 
		public CUInt32 Bbcharge
		{
			get => GetProperty(ref _bbcharge);
			set => SetProperty(ref _bbcharge, value);
		}

		[Ordinal(29)] 
		[RED("meleeResourcePoolListener")] 
		public CHandle<MeleeResourcePoolListener> MeleeResourcePoolListener
		{
			get => GetProperty(ref _meleeResourcePoolListener);
			set => SetProperty(ref _meleeResourcePoolListener, value);
		}

		[Ordinal(30)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(31)] 
		[RED("displayChargeBar")] 
		public CBool DisplayChargeBar
		{
			get => GetProperty(ref _displayChargeBar);
			set => SetProperty(ref _displayChargeBar, value);
		}
	}
}
