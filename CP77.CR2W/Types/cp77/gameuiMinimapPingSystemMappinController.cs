using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapPingSystemMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("rootWidget")] public inkWidgetReference RootWidget { get; set; }

		public gameuiMinimapPingSystemMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
