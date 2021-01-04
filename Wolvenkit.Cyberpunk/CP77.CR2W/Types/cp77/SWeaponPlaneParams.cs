using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SWeaponPlaneParams : CVariable
	{
		[Ordinal(0)]  [RED("blurIntensity")] public CFloat BlurIntensity { get; set; }
		[Ordinal(1)]  [RED("weaponNearPlaneCM")] public CFloat WeaponNearPlaneCM { get; set; }

		public SWeaponPlaneParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
