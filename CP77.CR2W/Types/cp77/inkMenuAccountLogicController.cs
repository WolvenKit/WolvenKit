using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMenuAccountLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("playerId")] public inkTextWidgetReference PlayerId { get; set; }
		[Ordinal(2)] [RED("changeAccountLabelTextRef")] public inkTextWidgetReference ChangeAccountLabelTextRef { get; set; }
		[Ordinal(3)] [RED("inputDisplayControllerRef")] public inkWidgetReference InputDisplayControllerRef { get; set; }
		[Ordinal(4)] [RED("changeAccountEnabled")] public CBool ChangeAccountEnabled { get; set; }

		public inkMenuAccountLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
