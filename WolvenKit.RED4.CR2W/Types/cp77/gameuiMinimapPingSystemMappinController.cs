using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapPingSystemMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _rootWidget;

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public inkWidgetReference RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		public gameuiMinimapPingSystemMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
