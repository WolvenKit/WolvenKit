using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CarRadioGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(2)]  [RED("radioStationName")] public inkTextWidgetReference RadioStationName { get; set; }
		[Ordinal(3)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(4)]  [RED("songName")] public inkTextWidgetReference SongName { get; set; }
		[Ordinal(5)]  [RED("songNameChangeBlackboardId")] public CUInt32 SongNameChangeBlackboardId { get; set; }
		[Ordinal(6)]  [RED("stateChangesBlackboardId")] public CUInt32 StateChangesBlackboardId { get; set; }

		public CarRadioGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
