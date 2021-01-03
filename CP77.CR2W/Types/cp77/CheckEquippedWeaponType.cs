using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckEquippedWeaponType : AIItemHandlingCondition
	{
		[Ordinal(0)]  [RED("weaponTypeToCheck")] public CName WeaponTypeToCheck { get; set; }

		public CheckEquippedWeaponType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
