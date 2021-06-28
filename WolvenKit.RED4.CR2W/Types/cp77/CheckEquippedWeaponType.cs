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
			get => GetProperty(ref _weaponTypeToCheck);
			set => SetProperty(ref _weaponTypeToCheck, value);
		}

		public CheckEquippedWeaponType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
