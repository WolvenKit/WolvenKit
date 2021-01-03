using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SceneScreenGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("onQuestAnimChangeListener")] public CUInt32 OnQuestAnimChangeListener { get; set; }

		public SceneScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
