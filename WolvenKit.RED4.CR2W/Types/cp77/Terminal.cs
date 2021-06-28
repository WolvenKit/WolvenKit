using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Terminal : InteractiveMasterDevice
	{
		private CHandle<ScriptableVirtualCameraViewComponent> _cameraFeed;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(96)] 
		[RED("cameraFeed")] 
		public CHandle<ScriptableVirtualCameraViewComponent> CameraFeed
		{
			get => GetProperty(ref _cameraFeed);
			set => SetProperty(ref _cameraFeed, value);
		}

		[Ordinal(97)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(98)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		public Terminal(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
