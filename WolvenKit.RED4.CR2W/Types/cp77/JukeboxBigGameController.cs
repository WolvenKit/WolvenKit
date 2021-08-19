using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxBigGameController : DeviceInkGameControllerBase
	{
		private CHandle<redCallbackObject> _onTogglePlayListener;

		[Ordinal(16)] 
		[RED("onTogglePlayListener")] 
		public CHandle<redCallbackObject> OnTogglePlayListener
		{
			get => GetProperty(ref _onTogglePlayListener);
			set => SetProperty(ref _onTogglePlayListener, value);
		}

		public JukeboxBigGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
