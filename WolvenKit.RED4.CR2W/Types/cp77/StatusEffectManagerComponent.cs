using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectManagerComponent : AIMandatoryComponents
	{
		private CBool _weaponDropedInWounded;

		[Ordinal(5)] 
		[RED("weaponDropedInWounded")] 
		public CBool WeaponDropedInWounded
		{
			get
			{
				if (_weaponDropedInWounded == null)
				{
					_weaponDropedInWounded = (CBool) CR2WTypeManager.Create("Bool", "weaponDropedInWounded", cr2w, this);
				}
				return _weaponDropedInWounded;
			}
			set
			{
				if (_weaponDropedInWounded == value)
				{
					return;
				}
				_weaponDropedInWounded = value;
				PropertySet(this);
			}
		}

		public StatusEffectManagerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
