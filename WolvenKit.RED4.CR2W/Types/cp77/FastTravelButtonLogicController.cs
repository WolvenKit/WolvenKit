using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelButtonLogicController : inkButtonController
	{
		[Ordinal(10)] [RED("districtName")] public inkTextWidgetReference DistrictName { get; set; }
		[Ordinal(11)] [RED("locationName")] public inkTextWidgetReference LocationName { get; set; }
		[Ordinal(12)] [RED("soundData")] public SSoundData SoundData { get; set; }
		[Ordinal(13)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(14)] [RED("fastTravelPointData")] public wCHandle<gameFastTravelPointData> FastTravelPointData { get; set; }

		public FastTravelButtonLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
