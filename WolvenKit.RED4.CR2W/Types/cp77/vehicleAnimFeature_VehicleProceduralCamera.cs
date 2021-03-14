using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleAnimFeature_VehicleProceduralCamera : animAnimFeature
	{
		private Vector4 _cameraTranslationVS;
		private Quaternion _cameraOrientationVS;

		[Ordinal(0)] 
		[RED("cameraTranslationVS")] 
		public Vector4 CameraTranslationVS
		{
			get
			{
				if (_cameraTranslationVS == null)
				{
					_cameraTranslationVS = (Vector4) CR2WTypeManager.Create("Vector4", "cameraTranslationVS", cr2w, this);
				}
				return _cameraTranslationVS;
			}
			set
			{
				if (_cameraTranslationVS == value)
				{
					return;
				}
				_cameraTranslationVS = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cameraOrientationVS")] 
		public Quaternion CameraOrientationVS
		{
			get
			{
				if (_cameraOrientationVS == null)
				{
					_cameraOrientationVS = (Quaternion) CR2WTypeManager.Create("Quaternion", "cameraOrientationVS", cr2w, this);
				}
				return _cameraOrientationVS;
			}
			set
			{
				if (_cameraOrientationVS == value)
				{
					return;
				}
				_cameraOrientationVS = value;
				PropertySet(this);
			}
		}

		public vehicleAnimFeature_VehicleProceduralCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
