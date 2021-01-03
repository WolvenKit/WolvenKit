using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponBlur : animAnimFeature
	{
		[Ordinal(0)]  [RED("weaponBlurIntensity")] public CFloat WeaponBlurIntensity { get; set; }
		[Ordinal(1)]  [RED("weaponBlurIntensity_aim")] public CFloat WeaponBlurIntensity_aim { get; set; }
		[Ordinal(2)]  [RED("weaponEdgesSharpness")] public CFloat WeaponEdgesSharpness { get; set; }
		[Ordinal(3)]  [RED("weaponEdgesSharpness_aim")] public CFloat WeaponEdgesSharpness_aim { get; set; }
		[Ordinal(4)]  [RED("weaponFarPlane")] public CFloat WeaponFarPlane { get; set; }
		[Ordinal(5)]  [RED("weaponFarPlane_aim")] public CFloat WeaponFarPlane_aim { get; set; }
		[Ordinal(6)]  [RED("weaponNearPlane")] public CFloat WeaponNearPlane { get; set; }
		[Ordinal(7)]  [RED("weaponNearPlane_aim")] public CFloat WeaponNearPlane_aim { get; set; }
		[Ordinal(8)]  [RED("weaponVignetteCircular")] public CFloat WeaponVignetteCircular { get; set; }
		[Ordinal(9)]  [RED("weaponVignetteCircular_aim")] public CFloat WeaponVignetteCircular_aim { get; set; }
		[Ordinal(10)]  [RED("weaponVignetteIntensity")] public CFloat WeaponVignetteIntensity { get; set; }
		[Ordinal(11)]  [RED("weaponVignetteIntensity_aim")] public CFloat WeaponVignetteIntensity_aim { get; set; }
		[Ordinal(12)]  [RED("weaponVignetteRadius")] public CFloat WeaponVignetteRadius { get; set; }
		[Ordinal(13)]  [RED("weaponVignetteRadius_aim")] public CFloat WeaponVignetteRadius_aim { get; set; }

		public AnimFeature_WeaponBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
