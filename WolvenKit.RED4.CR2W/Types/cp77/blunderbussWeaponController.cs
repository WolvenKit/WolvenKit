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
			get
			{
				if (_chargeWidgetInitialY == null)
				{
					_chargeWidgetInitialY = (CFloat) CR2WTypeManager.Create("Float", "chargeWidgetInitialY", cr2w, this);
				}
				return _chargeWidgetInitialY;
			}
			set
			{
				if (_chargeWidgetInitialY == value)
				{
					return;
				}
				_chargeWidgetInitialY = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("chargeWidgetSize")] 
		public Vector2 ChargeWidgetSize
		{
			get
			{
				if (_chargeWidgetSize == null)
				{
					_chargeWidgetSize = (Vector2) CR2WTypeManager.Create("Vector2", "chargeWidgetSize", cr2w, this);
				}
				return _chargeWidgetSize;
			}
			set
			{
				if (_chargeWidgetSize == value)
				{
					return;
				}
				_chargeWidgetSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("semiAutoModeInfo")] 
		public wCHandle<inkWidget> SemiAutoModeInfo
		{
			get
			{
				if (_semiAutoModeInfo == null)
				{
					_semiAutoModeInfo = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "semiAutoModeInfo", cr2w, this);
				}
				return _semiAutoModeInfo;
			}
			set
			{
				if (_semiAutoModeInfo == value)
				{
					return;
				}
				_semiAutoModeInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("chargeModeInfo")] 
		public wCHandle<inkWidget> ChargeModeInfo
		{
			get
			{
				if (_chargeModeInfo == null)
				{
					_chargeModeInfo = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "chargeModeInfo", cr2w, this);
				}
				return _chargeModeInfo;
			}
			set
			{
				if (_chargeModeInfo == value)
				{
					return;
				}
				_chargeModeInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("semiAutoModeIndicator")] 
		public wCHandle<inkWidget> SemiAutoModeIndicator
		{
			get
			{
				if (_semiAutoModeIndicator == null)
				{
					_semiAutoModeIndicator = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "semiAutoModeIndicator", cr2w, this);
				}
				return _semiAutoModeIndicator;
			}
			set
			{
				if (_semiAutoModeIndicator == value)
				{
					return;
				}
				_semiAutoModeIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("chargeModeIndicator")] 
		public wCHandle<inkWidget> ChargeModeIndicator
		{
			get
			{
				if (_chargeModeIndicator == null)
				{
					_chargeModeIndicator = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "chargeModeIndicator", cr2w, this);
				}
				return _chargeModeIndicator;
			}
			set
			{
				if (_chargeModeIndicator == value)
				{
					return;
				}
				_chargeModeIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("shots")] 
		public CArray<wCHandle<inkWidget>> Shots
		{
			get
			{
				if (_shots == null)
				{
					_shots = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "shots", cr2w, this);
				}
				return _shots;
			}
			set
			{
				if (_shots == value)
				{
					return;
				}
				_shots = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("charge")] 
		public wCHandle<inkWidget> Charge
		{
			get
			{
				if (_charge == null)
				{
					_charge = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "charge", cr2w, this);
				}
				return _charge;
			}
			set
			{
				if (_charge == value)
				{
					return;
				}
				_charge = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("onCharge")] 
		public CUInt32 OnCharge
		{
			get
			{
				if (_onCharge == null)
				{
					_onCharge = (CUInt32) CR2WTypeManager.Create("Uint32", "onCharge", cr2w, this);
				}
				return _onCharge;
			}
			set
			{
				if (_onCharge == value)
				{
					return;
				}
				_onCharge = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("onTriggerMode")] 
		public CUInt32 OnTriggerMode
		{
			get
			{
				if (_onTriggerMode == null)
				{
					_onTriggerMode = (CUInt32) CR2WTypeManager.Create("Uint32", "onTriggerMode", cr2w, this);
				}
				return _onTriggerMode;
			}
			set
			{
				if (_onTriggerMode == value)
				{
					return;
				}
				_onTriggerMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("onMagazineAmmoCount")] 
		public CUInt32 OnMagazineAmmoCount
		{
			get
			{
				if (_onMagazineAmmoCount == null)
				{
					_onMagazineAmmoCount = (CUInt32) CR2WTypeManager.Create("Uint32", "onMagazineAmmoCount", cr2w, this);
				}
				return _onMagazineAmmoCount;
			}
			set
			{
				if (_onMagazineAmmoCount == value)
				{
					return;
				}
				_onMagazineAmmoCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (wCHandle<gameIBlackboard>) CR2WTypeManager.Create("whandle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		public blunderbussWeaponController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
