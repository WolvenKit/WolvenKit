using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewGameController : gameuiPreviewGameController
	{
		private gameuiPuppetPreviewCameraController _cameraController;

		[Ordinal(7)] 
		[RED("cameraController")] 
		public gameuiPuppetPreviewCameraController CameraController
		{
			get => GetProperty(ref _cameraController);
			set => SetProperty(ref _cameraController, value);
		}

		public gameuiPuppetPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
