using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkPlatformSpecificTextController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("textLocKey")] public CName TextLocKey { get; set; }
		[Ordinal(1)]  [RED("textLocKey_PS4")] public CName TextLocKey_PS4 { get; set; }
		[Ordinal(2)]  [RED("textLocKey_XB1")] public CName TextLocKey_XB1 { get; set; }

		public inkPlatformSpecificTextController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
