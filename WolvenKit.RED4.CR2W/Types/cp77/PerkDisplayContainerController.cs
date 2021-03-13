using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(2)] [RED("isTrait")] public CBool IsTrait { get; set; }
		[Ordinal(3)] [RED("widget")] public inkWidgetReference Widget { get; set; }
		[Ordinal(4)] [RED("data")] public CHandle<BasePerkDisplayData> Data { get; set; }
		[Ordinal(5)] [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(6)] [RED("controller")] public CHandle<PerkDisplayController> Controller { get; set; }

		public PerkDisplayContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
