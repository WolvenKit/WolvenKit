using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LoopAnimationLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("defaultAnimation")] public CName DefaultAnimation { get; set; }
		[Ordinal(1)]  [RED("selectionRule")] public CEnum<inkSelectionRule> SelectionRule { get; set; }

		public LoopAnimationLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
