using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigTypeMeleeWeaponConfigurationMapItem : CVariable
	{
		[Ordinal(0)]  [RED("meleeWeaponConfiguration")] public CName MeleeWeaponConfiguration { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }

		public audioMeleeRigTypeMeleeWeaponConfigurationMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
