using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SWeaponPlaneParams : CVariable
	{
		[Ordinal(0)]  [RED("blurIntensity")] public CFloat BlurIntensity { get; set; }
		[Ordinal(1)]  [RED("weaponNearPlaneCM")] public CFloat WeaponNearPlaneCM { get; set; }

		public SWeaponPlaneParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
