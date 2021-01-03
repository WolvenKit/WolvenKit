using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LoopAnimationLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("defaultAnimation")] public CName DefaultAnimation { get; set; }
		[Ordinal(1)]  [RED("selectionRule")] public CEnum<inkSelectionRule> SelectionRule { get; set; }

		public LoopAnimationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
