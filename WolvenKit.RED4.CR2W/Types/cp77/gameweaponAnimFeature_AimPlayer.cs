using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_AimPlayer : animAnimFeature_BasicAim
	{
		[Ordinal(2)] [RED("zoomLevel")] public CFloat ZoomLevel { get; set; }
		[Ordinal(3)] [RED("aimInTime")] public CFloat AimInTime { get; set; }
		[Ordinal(4)] [RED("aimOutTime")] public CFloat AimOutTime { get; set; }

		public gameweaponAnimFeature_AimPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
