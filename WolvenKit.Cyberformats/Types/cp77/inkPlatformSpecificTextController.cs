using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificTextController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("textLocKey")] public CName TextLocKey { get; set; }
		[Ordinal(2)] [RED("textLocKey_PS4")] public CName TextLocKey_PS4 { get; set; }
		[Ordinal(3)] [RED("textLocKey_XB1")] public CName TextLocKey_XB1 { get; set; }

		public inkPlatformSpecificTextController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
