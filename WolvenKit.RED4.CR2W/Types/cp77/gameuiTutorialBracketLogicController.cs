using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTutorialBracketLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("loopAnim")] public CHandle<inkanimProxy> LoopAnim { get; set; }

		public gameuiTutorialBracketLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
