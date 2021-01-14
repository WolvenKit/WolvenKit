using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleAnimFeature_VehicleProceduralCamera : animAnimFeature
	{
		[Ordinal(0)]  [RED("cameraOrientationVS")] public Quaternion CameraOrientationVS { get; set; }
		[Ordinal(1)]  [RED("cameraTranslationVS")] public Vector4 CameraTranslationVS { get; set; }

		public vehicleAnimFeature_VehicleProceduralCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
