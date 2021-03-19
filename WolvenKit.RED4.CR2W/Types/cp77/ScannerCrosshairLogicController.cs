using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerCrosshairLogicController : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkScreenProjection> _projection;

		[Ordinal(1)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(2)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get => GetProperty(ref _projection);
			set => SetProperty(ref _projection, value);
		}

		public ScannerCrosshairLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
