using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_ActiveWeaponDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("RightWeaponRecordID")] 
		public gamebbScriptID_Variant RightWeaponRecordID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("LeftWeaponRecordID")] 
		public gamebbScriptID_Variant LeftWeaponRecordID
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("BulletSpread")] 
		public gamebbScriptID_Vector2 BulletSpread
		{
			get => GetPropertyValue<gamebbScriptID_Vector2>();
			set => SetPropertyValue<gamebbScriptID_Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("SmartGunParams")] 
		public gamebbScriptID_Variant SmartGunParams
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(4)] 
		[RED("TargetHitEvent")] 
		public gamebbScriptID_Variant TargetHitEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(5)] 
		[RED("ShootEvent")] 
		public gamebbScriptID_Variant ShootEvent
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_ActiveWeaponDataDef()
		{
			RightWeaponRecordID = new gamebbScriptID_Variant();
			LeftWeaponRecordID = new gamebbScriptID_Variant();
			BulletSpread = new gamebbScriptID_Vector2();
			SmartGunParams = new gamebbScriptID_Variant();
			TargetHitEvent = new gamebbScriptID_Variant();
			ShootEvent = new gamebbScriptID_Variant();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
