using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(1)]  [RED("isTrait")] public CBool IsTrait { get; set; }
		[Ordinal(2)]  [RED("widget")] public inkWidgetReference Widget { get; set; }
		[Ordinal(3)]  [RED("data")] public CHandle<BasePerkDisplayData> Data { get; set; }
		[Ordinal(4)]  [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(5)]  [RED("controller")] public CHandle<PerkDisplayController> Controller { get; set; }

		public PerkDisplayContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
