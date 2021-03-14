using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Float _charge;
		private gamebbScriptID_Float _overheatPercentage;
		private gamebbScriptID_Bool _isInForcedOverheatCooldown;
		private gamebbScriptID_Variant _chargeStep;
		private gamebbScriptID_Variant _triggerMode;
		private gamebbScriptID_Uint32 _magazineAmmoCapacity;
		private gamebbScriptID_Uint32 _magazineAmmoCount;
		private gamebbScriptID_Variant _magazineAmmoID;

		[Ordinal(0)] 
		[RED("Charge")] 
		public gamebbScriptID_Float Charge
		{
			get
			{
				if (_charge == null)
				{
					_charge = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "Charge", cr2w, this);
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

		[Ordinal(1)] 
		[RED("OverheatPercentage")] 
		public gamebbScriptID_Float OverheatPercentage
		{
			get
			{
				if (_overheatPercentage == null)
				{
					_overheatPercentage = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "OverheatPercentage", cr2w, this);
				}
				return _overheatPercentage;
			}
			set
			{
				if (_overheatPercentage == value)
				{
					return;
				}
				_overheatPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("IsInForcedOverheatCooldown")] 
		public gamebbScriptID_Bool IsInForcedOverheatCooldown
		{
			get
			{
				if (_isInForcedOverheatCooldown == null)
				{
					_isInForcedOverheatCooldown = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsInForcedOverheatCooldown", cr2w, this);
				}
				return _isInForcedOverheatCooldown;
			}
			set
			{
				if (_isInForcedOverheatCooldown == value)
				{
					return;
				}
				_isInForcedOverheatCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ChargeStep")] 
		public gamebbScriptID_Variant ChargeStep
		{
			get
			{
				if (_chargeStep == null)
				{
					_chargeStep = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ChargeStep", cr2w, this);
				}
				return _chargeStep;
			}
			set
			{
				if (_chargeStep == value)
				{
					return;
				}
				_chargeStep = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("TriggerMode")] 
		public gamebbScriptID_Variant TriggerMode
		{
			get
			{
				if (_triggerMode == null)
				{
					_triggerMode = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "TriggerMode", cr2w, this);
				}
				return _triggerMode;
			}
			set
			{
				if (_triggerMode == value)
				{
					return;
				}
				_triggerMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("MagazineAmmoCapacity")] 
		public gamebbScriptID_Uint32 MagazineAmmoCapacity
		{
			get
			{
				if (_magazineAmmoCapacity == null)
				{
					_magazineAmmoCapacity = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "MagazineAmmoCapacity", cr2w, this);
				}
				return _magazineAmmoCapacity;
			}
			set
			{
				if (_magazineAmmoCapacity == value)
				{
					return;
				}
				_magazineAmmoCapacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("MagazineAmmoCount")] 
		public gamebbScriptID_Uint32 MagazineAmmoCount
		{
			get
			{
				if (_magazineAmmoCount == null)
				{
					_magazineAmmoCount = (gamebbScriptID_Uint32) CR2WTypeManager.Create("gamebbScriptID_Uint32", "MagazineAmmoCount", cr2w, this);
				}
				return _magazineAmmoCount;
			}
			set
			{
				if (_magazineAmmoCount == value)
				{
					return;
				}
				_magazineAmmoCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("MagazineAmmoID")] 
		public gamebbScriptID_Variant MagazineAmmoID
		{
			get
			{
				if (_magazineAmmoID == null)
				{
					_magazineAmmoID = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MagazineAmmoID", cr2w, this);
				}
				return _magazineAmmoID;
			}
			set
			{
				if (_magazineAmmoID == value)
				{
					return;
				}
				_magazineAmmoID = value;
				PropertySet(this);
			}
		}

		public WeaponDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
