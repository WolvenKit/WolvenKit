using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkCanvasWidget> _defaultUI;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private wCHandle<inkTextWidget> _counterWidget;
		private CUInt32 _onGlitchingStateChangedListener;
		private CUInt32 _onTimeToDepartChangedListener;

		[Ordinal(16)] 
		[RED("defaultUI")] 
		public wCHandle<inkCanvasWidget> DefaultUI
		{
			get => GetProperty(ref _defaultUI);
			set => SetProperty(ref _defaultUI, value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(18)] 
		[RED("counterWidget")] 
		public wCHandle<inkTextWidget> CounterWidget
		{
			get => GetProperty(ref _counterWidget);
			set => SetProperty(ref _counterWidget, value);
		}

		[Ordinal(19)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		[Ordinal(20)] 
		[RED("onTimeToDepartChangedListener")] 
		public CUInt32 OnTimeToDepartChangedListener
		{
			get => GetProperty(ref _onTimeToDepartChangedListener);
			set => SetProperty(ref _onTimeToDepartChangedListener, value);
		}

		public NcartTimetableInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
