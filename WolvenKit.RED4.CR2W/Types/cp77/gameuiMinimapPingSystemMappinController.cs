using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapPingSystemMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] [RED("rootWidget")] public inkWidgetReference RootWidget { get; set; }

		public gameuiMinimapPingSystemMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
