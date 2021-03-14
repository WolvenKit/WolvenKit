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
			get
			{
				if (_weaponLoweringSpeedOverride == null)
				{
					_weaponLoweringSpeedOverride = (CFloat) CR2WTypeManager.Create("Float", "weaponLoweringSpeedOverride", cr2w, this);
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

		public SceneForceWeaponSafe(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
