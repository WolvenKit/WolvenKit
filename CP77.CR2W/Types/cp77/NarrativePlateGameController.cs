using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(0)]  [RED("logicController")] public wCHandle<NarrativePlateLogicController> LogicController { get; set; }
		[Ordinal(1)]  [RED("narrativePlateBlackboard")] public CHandle<gameIBlackboard> NarrativePlateBlackboard { get; set; }
		[Ordinal(2)]  [RED("narrativePlateBlackboardText")] public CUInt32 NarrativePlateBlackboardText { get; set; }
		[Ordinal(3)]  [RED("plateHolder")] public inkWidgetReference PlateHolder { get; set; }
		[Ordinal(4)]  [RED("projection")] public CHandle<inkScreenProjection> Projection { get; set; }

		public NarrativePlateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
