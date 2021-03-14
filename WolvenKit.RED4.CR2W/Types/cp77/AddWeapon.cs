using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddWeapon : AIbehaviortaskScript
	{
		private CEnum<EquipmentPriority> _weapon;

		[Ordinal(0)] 
		[RED("weapon")] 
		public CEnum<EquipmentPriority> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (CEnum<EquipmentPriority>) CR2WTypeManager.Create("EquipmentPriority", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		public AddWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
