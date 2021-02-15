using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class KillMarkerGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("targetNeutralized")] public CUInt32 TargetNeutralized { get; set; }
		[Ordinal(3)] [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(4)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public KillMarkerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
