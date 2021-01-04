using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMenuAccountLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("changeAccountEnabled")] public CBool ChangeAccountEnabled { get; set; }
		[Ordinal(1)]  [RED("changeAccountLabelTextRef")] public inkTextWidgetReference ChangeAccountLabelTextRef { get; set; }
		[Ordinal(2)]  [RED("inputDisplayControllerRef")] public inkWidgetReference InputDisplayControllerRef { get; set; }
		[Ordinal(3)]  [RED("playerId")] public inkTextWidgetReference PlayerId { get; set; }

		public inkMenuAccountLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
