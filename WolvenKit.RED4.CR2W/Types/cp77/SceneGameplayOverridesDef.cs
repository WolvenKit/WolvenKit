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
			get => GetProperty(ref _aimForced);
			set => SetProperty(ref _aimForced, value);
		}

		[Ordinal(1)] 
		[RED("SafeForced")] 
		public gamebbScriptID_Bool SafeForced
		{
			get => GetProperty(ref _safeForced);
			set => SetProperty(ref _safeForced, value);
		}

		[Ordinal(2)] 
		[RED("WeaponLoweringSpeedOverride")] 
		public gamebbScriptID_Float WeaponLoweringSpeedOverride
		{
			get => GetProperty(ref _weaponLoweringSpeedOverride);
			set => SetProperty(ref _weaponLoweringSpeedOverride, value);
		}

		public SceneGameplayOverridesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
