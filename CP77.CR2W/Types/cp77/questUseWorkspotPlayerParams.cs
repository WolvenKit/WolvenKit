using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUseWorkspotPlayerParams : CVariable
	{
		[Ordinal(0)] [RED("tier")] public CEnum<questUseWorkspotTier> Tier { get; set; }
		[Ordinal(1)] [RED("cameraSettings")] public gameTier3CameraSettings CameraSettings { get; set; }
		[Ordinal(2)] [RED("emptyHands")] public CBool EmptyHands { get; set; }
		[Ordinal(3)] [RED("cameraUseTrajectorySpace")] public CBool CameraUseTrajectorySpace { get; set; }
		[Ordinal(4)] [RED("applyCameraParams")] public CBool ApplyCameraParams { get; set; }
		[Ordinal(5)] [RED("vehicleProceduralCameraWeight")] public CFloat VehicleProceduralCameraWeight { get; set; }
		[Ordinal(6)] [RED("parallaxWeight")] public CFloat ParallaxWeight { get; set; }
		[Ordinal(7)] [RED("parallaxSpace")] public CEnum<questCameraParallaxSpace> ParallaxSpace { get; set; }

		public questUseWorkspotPlayerParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
