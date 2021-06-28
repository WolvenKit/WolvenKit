using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IntercomInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _actionsList;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private CHandle<CallActionWidgetController> _buttonRef;
		private CEnum<IntercomStatus> _state;
		private CUInt32 _onUpdateStatusListener;
		private CUInt32 _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("actionsList")] 
		public inkWidgetReference ActionsList
		{
			get => GetProperty(ref _actionsList);
			set => SetProperty(ref _actionsList, value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(18)] 
		[RED("buttonRef")] 
		public CHandle<CallActionWidgetController> ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}

		[Ordinal(19)] 
		[RED("state")] 
		public CEnum<IntercomStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(20)] 
		[RED("onUpdateStatusListener")] 
		public CUInt32 OnUpdateStatusListener
		{
			get => GetProperty(ref _onUpdateStatusListener);
			set => SetProperty(ref _onUpdateStatusListener, value);
		}

		[Ordinal(21)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		public IntercomInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
