using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CarRadioGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("radioStationName")] public inkTextWidgetReference RadioStationName { get; set; }
		[Ordinal(10)] [RED("songName")] public inkTextWidgetReference SongName { get; set; }
		[Ordinal(11)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(12)] [RED("stateChangesBlackboardId")] public CUInt32 StateChangesBlackboardId { get; set; }
		[Ordinal(13)] [RED("songNameChangeBlackboardId")] public CUInt32 SongNameChangeBlackboardId { get; set; }
		[Ordinal(14)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(15)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public CarRadioGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
