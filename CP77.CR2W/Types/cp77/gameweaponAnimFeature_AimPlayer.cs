using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_AimPlayer : animAnimFeature_BasicAim
	{
		[Ordinal(0)]  [RED("zoomLevel")] public CFloat ZoomLevel { get; set; }
		[Ordinal(1)]  [RED("aimInTime")] public CFloat AimInTime { get; set; }
		[Ordinal(2)]  [RED("aimOutTime")] public CFloat AimOutTime { get; set; }

		public gameweaponAnimFeature_AimPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
