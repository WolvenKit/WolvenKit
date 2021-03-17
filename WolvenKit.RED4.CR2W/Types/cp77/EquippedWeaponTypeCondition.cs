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
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}

		public EquippedWeaponTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
