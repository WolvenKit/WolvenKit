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
			get
			{
				if (_cameraSettings == null)
				{
					_cameraSettings = (gameuiEntityPreviewCameraSettings) CR2WTypeManager.Create("gameuiEntityPreviewCameraSettings", "cameraSettings", cr2w, this);
				}
				return _cameraSettings;
			}
			set
			{
				if (_cameraSettings == value)
				{
					return;
				}
				_cameraSettings = value;
				PropertySet(this);
			}
		}

		public gameuiEntityPreviewGameObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
