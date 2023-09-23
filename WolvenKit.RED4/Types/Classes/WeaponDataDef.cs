using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("Charge")] 
		public gamebbScriptID_Float Charge
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(1)] 
		[RED("OverheatPercentage")] 
		public gamebbScriptID_Float OverheatPercentage
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("IsInForcedOverheatCooldown")] 
		public gamebbScriptID_Bool IsInForcedOverheatCooldown
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("ChargeStep")] 
		public gamebbScriptID_Variant ChargeStep
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("TriggerMode")] 
		public gamebbScriptID_Variant TriggerMode
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("MagazineAmmoCapacity")] 
		public gamebbScriptID_Uint32 MagazineAmmoCapacity
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(6)] 
		[RED("MagazineAmmoCount")] 
		public gamebbScriptID_Uint32 MagazineAmmoCount
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(7)] 
		[RED("MagazineAmmoID")] 
		public gamebbScriptID_Variant MagazineAmmoID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public WeaponDataDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
