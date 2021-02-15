using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponHandlingStats : animAnimFeature
	{
		[Ordinal(0)] [RED("weaponRecoil")] public CFloat WeaponRecoil { get; set; }
		[Ordinal(1)] [RED("weaponSpread")] public CFloat WeaponSpread { get; set; }

		public AnimFeature_WeaponHandlingStats(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
