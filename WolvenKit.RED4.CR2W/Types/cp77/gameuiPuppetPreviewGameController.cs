using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPuppetPreviewGameController : gameuiPreviewGameController
	{
		private gameuiPuppetPreviewCameraController _cameraController;

		[Ordinal(6)] 
		[RED("cameraController")] 
		public gameuiPuppetPreviewCameraController CameraController
		{
			get
			{
				if (_cameraController == null)
				{
					_cameraController = (gameuiPuppetPreviewCameraController) CR2WTypeManager.Create("gameuiPuppetPreviewCameraController", "cameraController", cr2w, this);
				}
				return _cameraController;
			}
			set
			{
				if (_cameraController == value)
				{
					return;
				}
				_cameraController = value;
				PropertySet(this);
			}
		}

		public gameuiPuppetPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
