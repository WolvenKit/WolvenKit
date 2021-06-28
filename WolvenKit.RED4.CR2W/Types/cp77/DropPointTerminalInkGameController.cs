using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPointTerminalInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _sellAction;
		private CUInt32 _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("sellAction")] 
		public inkWidgetReference SellAction
		{
			get => GetProperty(ref _sellAction);
			set => SetProperty(ref _sellAction, value);
		}

		[Ordinal(17)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		public DropPointTerminalInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
