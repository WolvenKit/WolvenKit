using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ActiveWeaponDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _weaponRecordID;
		private gamebbScriptID_Vector2 _bulletSpread;
		private gamebbScriptID_Variant _smartGunParams;
		private gamebbScriptID_Variant _targetHitEvent;
		private gamebbScriptID_Variant _shootEvent;

		[Ordinal(0)] 
		[RED("WeaponRecordID")] 
		public gamebbScriptID_Variant WeaponRecordID
		{
			get => GetProperty(ref _weaponRecordID);
			set => SetProperty(ref _weaponRecordID, value);
		}

		[Ordinal(1)] 
		[RED("BulletSpread")] 
		public gamebbScriptID_Vector2 BulletSpread
		{
			get => GetProperty(ref _bulletSpread);
			set => SetProperty(ref _bulletSpread, value);
		}

		[Ordinal(2)] 
		[RED("SmartGunParams")] 
		public gamebbScriptID_Variant SmartGunParams
		{
			get => GetProperty(ref _smartGunParams);
			set => SetProperty(ref _smartGunParams, value);
		}

		[Ordinal(3)] 
		[RED("TargetHitEvent")] 
		public gamebbScriptID_Variant TargetHitEvent
		{
			get => GetProperty(ref _targetHitEvent);
			set => SetProperty(ref _targetHitEvent, value);
		}

		[Ordinal(4)] 
		[RED("ShootEvent")] 
		public gamebbScriptID_Variant ShootEvent
		{
			get => GetProperty(ref _shootEvent);
			set => SetProperty(ref _shootEvent, value);
		}

		public UI_ActiveWeaponDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
