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
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(1)] 
		[RED("OverheatPercentage")] 
		public gamebbScriptID_Float OverheatPercentage
		{
			get => GetProperty(ref _overheatPercentage);
			set => SetProperty(ref _overheatPercentage, value);
		}

		[Ordinal(2)] 
		[RED("IsInForcedOverheatCooldown")] 
		public gamebbScriptID_Bool IsInForcedOverheatCooldown
		{
			get => GetProperty(ref _isInForcedOverheatCooldown);
			set => SetProperty(ref _isInForcedOverheatCooldown, value);
		}

		[Ordinal(3)] 
		[RED("ChargeStep")] 
		public gamebbScriptID_Variant ChargeStep
		{
			get => GetProperty(ref _chargeStep);
			set => SetProperty(ref _chargeStep, value);
		}

		[Ordinal(4)] 
		[RED("TriggerMode")] 
		public gamebbScriptID_Variant TriggerMode
		{
			get => GetProperty(ref _triggerMode);
			set => SetProperty(ref _triggerMode, value);
		}

		[Ordinal(5)] 
		[RED("MagazineAmmoCapacity")] 
		public gamebbScriptID_Uint32 MagazineAmmoCapacity
		{
			get => GetProperty(ref _magazineAmmoCapacity);
			set => SetProperty(ref _magazineAmmoCapacity, value);
		}

		[Ordinal(6)] 
		[RED("MagazineAmmoCount")] 
		public gamebbScriptID_Uint32 MagazineAmmoCount
		{
			get => GetProperty(ref _magazineAmmoCount);
			set => SetProperty(ref _magazineAmmoCount, value);
		}

		[Ordinal(7)] 
		[RED("MagazineAmmoID")] 
		public gamebbScriptID_Variant MagazineAmmoID
		{
			get => GetProperty(ref _magazineAmmoID);
			set => SetProperty(ref _magazineAmmoID, value);
		}

		public WeaponDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
