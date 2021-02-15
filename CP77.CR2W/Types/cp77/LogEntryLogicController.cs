using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LogEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(2)] [RED("textWidget")] public inkTextWidgetReference TextWidget { get; set; }
		[Ordinal(3)] [RED("animProxyTimeout")] public CHandle<inkanimProxy> AnimProxyTimeout { get; set; }
		[Ordinal(4)] [RED("animProxyFadeOut")] public CHandle<inkanimProxy> AnimProxyFadeOut { get; set; }

		public LogEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
