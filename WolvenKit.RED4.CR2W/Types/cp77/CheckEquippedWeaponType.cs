using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckEquippedWeaponType : AIItemHandlingCondition
	{
		private CName _weaponTypeToCheck;

		[Ordinal(0)] 
		[RED("weaponTypeToCheck")] 
		public CName WeaponTypeToCheck
		{
			get
			{
				if (_weaponTypeToCheck == null)
				{
					_weaponTypeToCheck = (CName) CR2WTypeManager.Create("CName", "weaponTypeToCheck", cr2w, this);
				}
				return _weaponTypeToCheck;
			}
			set
			{
				if (_weaponTypeToCheck == value)
				{
					return;
				}
				_weaponTypeToCheck = value;
				PropertySet(this);
			}
		}

		public CheckEquippedWeaponType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
