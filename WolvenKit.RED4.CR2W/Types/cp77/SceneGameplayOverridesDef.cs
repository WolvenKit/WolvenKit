using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneGameplayOverridesDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _aimForced;
		private gamebbScriptID_Bool _safeForced;
		private gamebbScriptID_Float _weaponLoweringSpeedOverride;

		[Ordinal(0)] 
		[RED("AimForced")] 
		public gamebbScriptID_Bool AimForced
		{
			get
			{
				if (_aimForced == null)
				{
					_aimForced = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "AimForced", cr2w, this);
				}
				return _aimForced;
			}
			set
			{
				if (_aimForced == value)
				{
					return;
				}
				_aimForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("SafeForced")] 
		public gamebbScriptID_Bool SafeForced
		{
			get
			{
				if (_safeForced == null)
				{
					_safeForced = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "SafeForced", cr2w, this);
				}
				return _safeForced;
			}
			set
			{
				if (_safeForced == value)
				{
					return;
				}
				_safeForced = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("WeaponLoweringSpeedOverride")] 
		public gamebbScriptID_Float WeaponLoweringSpeedOverride
		{
			get
			{
				if (_weaponLoweringSpeedOverride == null)
				{
					_weaponLoweringSpeedOverride = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "WeaponLoweringSpeedOverride", cr2w, this);
				}
				return _weaponLoweringSpeedOverride;
			}
			set
			{
				if (_weaponLoweringSpeedOverride == value)
				{
					return;
				}
				_weaponLoweringSpeedOverride = value;
				PropertySet(this);
			}
		}

		public SceneGameplayOverridesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
