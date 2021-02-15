using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDPhoneElement : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }

		public HUDPhoneElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
