using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class blunderbussWeaponController : gameuiWidgetGameController
	{
		private CFloat _chargeWidgetInitialY;
		private Vector2 _chargeWidgetSize;
		private CWeakHandle<inkWidget> _semiAutoModeInfo;
		private CWeakHandle<inkWidget> _chargeModeInfo;
		private CWeakHandle<inkWidget> _semiAutoModeIndicator;
		private CWeakHandle<inkWidget> _chargeModeIndicator;
		private CArray<CWeakHandle<inkWidget>> _shots;
		private CWeakHandle<inkWidget> _charge;
		private CHandle<redCallbackObject> _onCharge;
		private CHandle<redCallbackObject> _onTriggerMode;
		private CHandle<redCallbackObject> _onMagazineAmmoCount;
		private CWeakHandle<gameIBlackboard> _blackboard;

		[Ordinal(2)] 
		[RED("chargeWidgetInitialY")] 
		public CFloat ChargeWidgetInitialY
		{
			get => GetProperty(ref _chargeWidgetInitialY);
			set => SetProperty(ref _chargeWidgetInitialY, value);
		}

		[Ordinal(3)] 
		[RED("chargeWidgetSize")] 
		public Vector2 ChargeWidgetSize
		{
			get => GetProperty(ref _chargeWidgetSize);
			set => SetProperty(ref _chargeWidgetSize, value);
		}

		[Ordinal(4)] 
		[RED("semiAutoModeInfo")] 
		public CWeakHandle<inkWidget> SemiAutoModeInfo
		{
			get => GetProperty(ref _semiAutoModeInfo);
			set => SetProperty(ref _semiAutoModeInfo, value);
		}

		[Ordinal(5)] 
		[RED("chargeModeInfo")] 
		public CWeakHandle<inkWidget> ChargeModeInfo
		{
			get => GetProperty(ref _chargeModeInfo);
			set => SetProperty(ref _chargeModeInfo, value);
		}

		[Ordinal(6)] 
		[RED("semiAutoModeIndicator")] 
		public CWeakHandle<inkWidget> SemiAutoModeIndicator
		{
			get => GetProperty(ref _semiAutoModeIndicator);
			set => SetProperty(ref _semiAutoModeIndicator, value);
		}

		[Ordinal(7)] 
		[RED("chargeModeIndicator")] 
		public CWeakHandle<inkWidget> ChargeModeIndicator
		{
			get => GetProperty(ref _chargeModeIndicator);
			set => SetProperty(ref _chargeModeIndicator, value);
		}

		[Ordinal(8)] 
		[RED("shots")] 
		public CArray<CWeakHandle<inkWidget>> Shots
		{
			get => GetProperty(ref _shots);
			set => SetProperty(ref _shots, value);
		}

		[Ordinal(9)] 
		[RED("charge")] 
		public CWeakHandle<inkWidget> Charge
		{
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(10)] 
		[RED("onCharge")] 
		public CHandle<redCallbackObject> OnCharge
		{
			get => GetProperty(ref _onCharge);
			set => SetProperty(ref _onCharge, value);
		}

		[Ordinal(11)] 
		[RED("onTriggerMode")] 
		public CHandle<redCallbackObject> OnTriggerMode
		{
			get => GetProperty(ref _onTriggerMode);
			set => SetProperty(ref _onTriggerMode, value);
		}

		[Ordinal(12)] 
		[RED("onMagazineAmmoCount")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCount
		{
			get => GetProperty(ref _onMagazineAmmoCount);
			set => SetProperty(ref _onMagazineAmmoCount, value);
		}

		[Ordinal(13)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}
	}
}
