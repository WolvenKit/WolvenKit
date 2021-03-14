using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquippedWeaponTypeCondition : workIScriptedCondition
	{
		private CEnum<WorkspotWeaponConditionEnum> _weaponType;

		[Ordinal(0)] 
		[RED("weaponType")] 
		public CEnum<WorkspotWeaponConditionEnum> WeaponType
		{
			get
			{
				if (_weaponType == null)
				{
					_weaponType = (CEnum<WorkspotWeaponConditionEnum>) CR2WTypeManager.Create("WorkspotWeaponConditionEnum", "weaponType", cr2w, this);
				}
				return _weaponType;
			}
			set
			{
				if (_weaponType == value)
				{
					return;
				}
				_weaponType = value;
				PropertySet(this);
			}
		}

		public EquippedWeaponTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
