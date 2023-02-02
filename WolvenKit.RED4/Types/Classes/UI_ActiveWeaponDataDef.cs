using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_ActiveWeaponDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("WeaponRecordID")] 
		public gamebbScriptID_Variant WeaponRecordID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("BulletSpread")] 
		public gamebbScriptID_Vector2 BulletSpread
		{
			get => GetPropertyValue<gamebbScriptID_Vector2>();
			set => SetPropertyValue<gamebbScriptID_Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("SmartGunParams")] 
		public gamebbScriptID_Variant SmartGunParams
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("TargetHitEvent")] 
		public gamebbScriptID_Variant TargetHitEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("ShootEvent")] 
		public gamebbScriptID_Variant ShootEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_ActiveWeaponDataDef()
		{
			WeaponRecordID = new();
			BulletSpread = new();
			SmartGunParams = new();
			TargetHitEvent = new();
			ShootEvent = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
