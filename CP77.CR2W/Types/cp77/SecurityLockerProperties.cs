using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityLockerProperties : CVariable
	{
		[Ordinal(0)]  [RED("disableCyberware")] public CBool DisableCyberware { get; set; }
		[Ordinal(1)]  [RED("pickUpWeaponSFX")] public CName PickUpWeaponSFX { get; set; }
		[Ordinal(2)]  [RED("securityLevelAccessGranted")] public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted { get; set; }
		[Ordinal(3)]  [RED("storeWeaponSFX")] public CName StoreWeaponSFX { get; set; }

		public SecurityLockerProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
