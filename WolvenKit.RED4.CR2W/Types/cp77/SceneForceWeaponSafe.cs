using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneForceWeaponSafe : redEvent
	{
		private CFloat _weaponLoweringSpeedOverride;

		[Ordinal(0)] 
		[RED("weaponLoweringSpeedOverride")] 
		public CFloat WeaponLoweringSpeedOverride
		{
			get => GetProperty(ref _weaponLoweringSpeedOverride);
			set => SetProperty(ref _weaponLoweringSpeedOverride, value);
		}

		public SceneForceWeaponSafe(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
