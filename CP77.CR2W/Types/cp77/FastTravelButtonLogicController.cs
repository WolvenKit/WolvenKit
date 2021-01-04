using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastTravelButtonLogicController : inkButtonController
	{
		[Ordinal(0)]  [RED("districtName")] public inkTextWidgetReference DistrictName { get; set; }
		[Ordinal(1)]  [RED("fastTravelPointData")] public wCHandle<gameFastTravelPointData> FastTravelPointData { get; set; }
		[Ordinal(2)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)]  [RED("locationName")] public inkTextWidgetReference LocationName { get; set; }
		[Ordinal(4)]  [RED("soundData")] public SSoundData SoundData { get; set; }

		public FastTravelButtonLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
