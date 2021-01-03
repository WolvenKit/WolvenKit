using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PrimaryWeaponTypeCondition : workIScriptedCondition
	{
		[Ordinal(0)]  [RED("weaponType")] public CEnum<WorkspotWeaponConditionEnum> WeaponType { get; set; }

		public PrimaryWeaponTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
