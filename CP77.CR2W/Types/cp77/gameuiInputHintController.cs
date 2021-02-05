using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("inputDisplayLibRef")] public inkWidgetLibraryReference InputDisplayLibRef { get; set; }
		[Ordinal(1)]  [RED("inputDisplayContainer")] public inkCompoundWidgetReference InputDisplayContainer { get; set; }
		[Ordinal(2)]  [RED("textWidgetRef")] public inkTextWidgetReference TextWidgetRef { get; set; }

		public gameuiInputHintController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
