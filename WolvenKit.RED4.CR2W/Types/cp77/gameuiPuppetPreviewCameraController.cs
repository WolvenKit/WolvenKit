using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewCameraController : CVariable
	{
		private CArray<gameuiPuppetPreviewCameraSetup> _cameraSetup;
		private CUInt32 _activeSetup;
		private CFloat _transitionDelay;

		[Ordinal(0)] 
		[RED("cameraSetup")] 
		public CArray<gameuiPuppetPreviewCameraSetup> CameraSetup
		{
			get => GetProperty(ref _cameraSetup);
			set => SetProperty(ref _cameraSetup, value);
		}

		[Ordinal(1)] 
		[RED("activeSetup")] 
		public CUInt32 ActiveSetup
		{
			get => GetProperty(ref _activeSetup);
			set => SetProperty(ref _activeSetup, value);
		}

		[Ordinal(2)] 
		[RED("transitionDelay")] 
		public CFloat TransitionDelay
		{
			get => GetProperty(ref _transitionDelay);
			set => SetProperty(ref _transitionDelay, value);
		}

		public gameuiPuppetPreviewCameraController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
