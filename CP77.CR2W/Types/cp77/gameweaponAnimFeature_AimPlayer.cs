using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_AimPlayer : animAnimFeature_BasicAim
	{
		[Ordinal(0)]  [RED("aimInTime")] public CFloat AimInTime { get; set; }
		[Ordinal(1)]  [RED("aimOutTime")] public CFloat AimOutTime { get; set; }
		[Ordinal(2)]  [RED("zoomLevel")] public CFloat ZoomLevel { get; set; }

		public gameweaponAnimFeature_AimPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
