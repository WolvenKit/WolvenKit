using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiEntityPreviewGameObject : gameObject
	{
		private gameuiEntityPreviewCameraSettings _cameraSettings;

		[Ordinal(40)] 
		[RED("cameraSettings")] 
		public gameuiEntityPreviewCameraSettings CameraSettings
		{
			get => GetProperty(ref _cameraSettings);
			set => SetProperty(ref _cameraSettings, value);
		}

		public gameuiEntityPreviewGameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
