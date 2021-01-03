using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LogEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animProxyFadeOut")] public CHandle<inkanimProxy> AnimProxyFadeOut { get; set; }
		[Ordinal(1)]  [RED("animProxyTimeout")] public CHandle<inkanimProxy> AnimProxyTimeout { get; set; }
		[Ordinal(2)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(3)]  [RED("textWidget")] public inkTextWidgetReference TextWidget { get; set; }

		public LogEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
