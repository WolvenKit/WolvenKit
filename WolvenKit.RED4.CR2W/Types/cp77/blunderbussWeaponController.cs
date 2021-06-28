using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class blunderbussWeaponController : gameuiWidgetGameController
	{
		private CFloat _chargeWidgetInitialY;
		private Vector2 _chargeWidgetSize;
		private wCHandle<inkWidget> _semiAutoModeInfo;
		private wCHandle<inkWidget> _chargeModeInfo;
		private wCHandle<inkWidget> _semiAutoModeIndicator;
		private wCHandle<inkWidget> _chargeModeIndicator;
		private CArray<wCHandle<inkWidget>> _shots;
		private wCHandle<inkWidget> _charge;
		private CUInt32 _onCharge;
		private CUInt32 _onTriggerMode;
		private CUInt32 _onMagazineAmmoCount;
		private wCHandle<gameIBlackboard> _blackboard;

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
		public wCHandle<inkWidget> SemiAutoModeInfo
		{
			get => GetProperty(ref _semiAutoModeInfo);
			set => SetProperty(ref _semiAutoModeInfo, value);
		}

		[Ordinal(5)] 
		[RED("chargeModeInfo")] 
		public wCHandle<inkWidget> ChargeModeInfo
		{
			get => GetProperty(ref _chargeModeInfo);
			set => SetProperty(ref _chargeModeInfo, value);
		}

		[Ordinal(6)] 
		[RED("semiAutoModeIndicator")] 
		public wCHandle<inkWidget> SemiAutoModeIndicator
		{
			get => GetProperty(ref _semiAutoModeIndicator);
			set => SetProperty(ref _semiAutoModeIndicator, value);
		}

		[Ordinal(7)] 
		[RED("chargeModeIndicator")] 
		public wCHandle<inkWidget> ChargeModeIndicator
		{
			get => GetProperty(ref _chargeModeIndicator);
			set => SetProperty(ref _chargeModeIndicator, value);
		}

		[Ordinal(8)] 
		[RED("shots")] 
		public CArray<wCHandle<inkWidget>> Shots
		{
			get => GetProperty(ref _shots);
			set => SetProperty(ref _shots, value);
		}

		[Ordinal(9)] 
		[RED("charge")] 
		public wCHandle<inkWidget> Charge
		{
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(10)] 
		[RED("onCharge")] 
		public CUInt32 OnCharge
		{
			get => GetProperty(ref _onCharge);
			set => SetProperty(ref _onCharge, value);
		}

		[Ordinal(11)] 
		[RED("onTriggerMode")] 
		public CUInt32 OnTriggerMode
		{
			get => GetProperty(ref _onTriggerMode);
			set => SetProperty(ref _onTriggerMode, value);
		}

		[Ordinal(12)] 
		[RED("onMagazineAmmoCount")] 
		public CUInt32 OnMagazineAmmoCount
		{
			get => GetProperty(ref _onMagazineAmmoCount);
			set => SetProperty(ref _onMagazineAmmoCount, value);
		}

		[Ordinal(13)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		public blunderbussWeaponController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
