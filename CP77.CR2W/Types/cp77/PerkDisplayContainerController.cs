using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("controller")] public CHandle<PerkDisplayController> Controller { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<BasePerkDisplayData> Data { get; set; }
		[Ordinal(2)]  [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(3)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(4)]  [RED("isTrait")] public CBool IsTrait { get; set; }
		[Ordinal(5)]  [RED("widget")] public inkWidgetReference Widget { get; set; }

		public PerkDisplayContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
