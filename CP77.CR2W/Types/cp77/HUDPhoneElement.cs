using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HUDPhoneElement : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("RootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }

		public HUDPhoneElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
