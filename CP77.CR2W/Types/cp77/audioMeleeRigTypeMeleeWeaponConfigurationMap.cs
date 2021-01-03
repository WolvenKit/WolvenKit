using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigTypeMeleeWeaponConfigurationMap : CVariable
	{
		[Ordinal(0)]  [RED("mapItems")] public CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> MapItems { get; set; }

		public audioMeleeRigTypeMeleeWeaponConfigurationMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
