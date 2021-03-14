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
			get
			{
				if (_weaponRecordID == null)
				{
					_weaponRecordID = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "WeaponRecordID", cr2w, this);
				}
				return _weaponRecordID;
			}
			set
			{
				if (_weaponRecordID == value)
				{
					return;
				}
				_weaponRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("BulletSpread")] 
		public gamebbScriptID_Vector2 BulletSpread
		{
			get
			{
				if (_bulletSpread == null)
				{
					_bulletSpread = (gamebbScriptID_Vector2) CR2WTypeManager.Create("gamebbScriptID_Vector2", "BulletSpread", cr2w, this);
				}
				return _bulletSpread;
			}
			set
			{
				if (_bulletSpread == value)
				{
					return;
				}
				_bulletSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SmartGunParams")] 
		public gamebbScriptID_Variant SmartGunParams
		{
			get
			{
				if (_smartGunParams == null)
				{
					_smartGunParams = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "SmartGunParams", cr2w, this);
				}
				return _smartGunParams;
			}
			set
			{
				if (_smartGunParams == value)
				{
					return;
				}
				_smartGunParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("TargetHitEvent")] 
		public gamebbScriptID_Variant TargetHitEvent
		{
			get
			{
				if (_targetHitEvent == null)
				{
					_targetHitEvent = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "TargetHitEvent", cr2w, this);
				}
				return _targetHitEvent;
			}
			set
			{
				if (_targetHitEvent == value)
				{
					return;
				}
				_targetHitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ShootEvent")] 
		public gamebbScriptID_Variant ShootEvent
		{
			get
			{
				if (_shootEvent == null)
				{
					_shootEvent = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ShootEvent", cr2w, this);
				}
				return _shootEvent;
			}
			set
			{
				if (_shootEvent == value)
				{
					return;
				}
				_shootEvent = value;
				PropertySet(this);
			}
		}

		public UI_ActiveWeaponDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
