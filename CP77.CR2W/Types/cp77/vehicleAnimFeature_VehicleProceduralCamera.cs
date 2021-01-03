using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleAnimFeature_VehicleProceduralCamera : animAnimFeature
	{
		[Ordinal(0)]  [RED("cameraOrientationVS")] public Quaternion CameraOrientationVS { get; set; }
		[Ordinal(1)]  [RED("cameraTranslationVS")] public Vector4 CameraTranslationVS { get; set; }

		public vehicleAnimFeature_VehicleProceduralCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
