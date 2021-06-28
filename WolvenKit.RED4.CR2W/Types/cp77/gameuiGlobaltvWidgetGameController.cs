using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGlobaltvWidgetGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _overlayContainer;

		[Ordinal(2)] 
		[RED("overlayContainer")] 
		public inkCompoundWidgetReference OverlayContainer
		{
			get => GetProperty(ref _overlayContainer);
			set => SetProperty(ref _overlayContainer, value);
		}

		public gameuiGlobaltvWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
