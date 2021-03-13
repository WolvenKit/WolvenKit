using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigTypeMeleeWeaponConfigurationMap : CVariable
	{
		[Ordinal(0)] [RED("mapItems")] public CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> MapItems { get; set; }

		public audioMeleeRigTypeMeleeWeaponConfigurationMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
