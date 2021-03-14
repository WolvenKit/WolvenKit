using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PainReactionTask : AIHitReactionTask
	{
		private CHandle<AnimFeature_WeaponOverride> _weaponOverride;

		[Ordinal(4)] 
		[RED("weaponOverride")] 
		public CHandle<AnimFeature_WeaponOverride> WeaponOverride
		{
			get
			{
				if (_weaponOverride == null)
				{
					_weaponOverride = (CHandle<AnimFeature_WeaponOverride>) CR2WTypeManager.Create("handle:AnimFeature_WeaponOverride", "weaponOverride", cr2w, this);
				}
				return _weaponOverride;
			}
			set
			{
				if (_weaponOverride == value)
				{
					return;
				}
				_weaponOverride = value;
				PropertySet(this);
			}
		}

		public PainReactionTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
