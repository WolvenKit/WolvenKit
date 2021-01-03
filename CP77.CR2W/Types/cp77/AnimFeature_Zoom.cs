using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Zoom : animAnimFeature
	{
		[Ordinal(0)]  [RED("finalZoomLevel")] public CFloat FinalZoomLevel { get; set; }
		[Ordinal(1)]  [RED("focusModeActive")] public CBool FocusModeActive { get; set; }
		[Ordinal(2)]  [RED("noWeaponAimInTime")] public CFloat NoWeaponAimInTime { get; set; }
		[Ordinal(3)]  [RED("noWeaponAimOutTime")] public CFloat NoWeaponAimOutTime { get; set; }
		[Ordinal(4)]  [RED("shouldUseWeaponZoomStats")] public CBool ShouldUseWeaponZoomStats { get; set; }
		[Ordinal(5)]  [RED("weaponAimFOV")] public CFloat WeaponAimFOV { get; set; }
		[Ordinal(6)]  [RED("weaponScopeFov")] public CFloat WeaponScopeFov { get; set; }
		[Ordinal(7)]  [RED("weaponZoomLevel")] public CFloat WeaponZoomLevel { get; set; }
		[Ordinal(8)]  [RED("worldFOV")] public CFloat WorldFOV { get; set; }
		[Ordinal(9)]  [RED("zoomLevelNum")] public CInt32 ZoomLevelNum { get; set; }

		public AnimFeature_Zoom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
