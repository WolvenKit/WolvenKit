using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SceneScreenGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("onQuestAnimChangeListener")] public CUInt32 OnQuestAnimChangeListener { get; set; }

		public SceneScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
