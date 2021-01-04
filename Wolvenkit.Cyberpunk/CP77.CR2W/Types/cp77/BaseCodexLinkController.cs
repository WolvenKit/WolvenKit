using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseCodexLinkController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("linkImage")] public inkImageWidgetReference LinkImage { get; set; }
		[Ordinal(2)]  [RED("linkLabel")] public inkTextWidgetReference LinkLabel { get; set; }

		public BaseCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
