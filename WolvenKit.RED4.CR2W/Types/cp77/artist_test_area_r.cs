using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class artist_test_area_r : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkCanvasWidget> _linesWidget;

		[Ordinal(9)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(10)] 
		[RED("linesWidget")] 
		public wCHandle<inkCanvasWidget> LinesWidget
		{
			get => GetProperty(ref _linesWidget);
			set => SetProperty(ref _linesWidget, value);
		}

		public artist_test_area_r(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
