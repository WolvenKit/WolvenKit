using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] [RED("plateHolder")] public inkWidgetReference PlateHolder { get; set; }
		[Ordinal(10)] [RED("projection")] public CHandle<inkScreenProjection> Projection { get; set; }
		[Ordinal(11)] [RED("narrativePlateBlackboard")] public CHandle<gameIBlackboard> NarrativePlateBlackboard { get; set; }
		[Ordinal(12)] [RED("narrativePlateBlackboardText")] public CUInt32 NarrativePlateBlackboardText { get; set; }
		[Ordinal(13)] [RED("logicController")] public wCHandle<NarrativePlateLogicController> LogicController { get; set; }

		public NarrativePlateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
