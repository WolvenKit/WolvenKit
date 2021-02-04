using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlayFPPControlAnimEvent : scnPlayAnimEvent
	{
		[Ordinal(0)]  [RED("gameplayAnimName")] public CHandle<scnAnimName> GameplayAnimName { get; set; }
		[Ordinal(1)]  [RED("FPPControlActive")] public CBool FPPControlActive { get; set; }
		[Ordinal(2)]  [RED("blendOverride")] public CEnum<scnfppBlendOverride> BlendOverride { get; set; }
		[Ordinal(3)]  [RED("cameraUseTrajectorySpace")] public CBool CameraUseTrajectorySpace { get; set; }
		[Ordinal(4)]  [RED("cameraBlendInDuration")] public CFloat CameraBlendInDuration { get; set; }
		[Ordinal(5)]  [RED("cameraBlendOutDuration")] public CFloat CameraBlendOutDuration { get; set; }
		[Ordinal(6)]  [RED("stayInScene")] public CBool StayInScene { get; set; }
		[Ordinal(7)]  [RED("idleIsMountedWorkspot")] public CBool IdleIsMountedWorkspot { get; set; }
		[Ordinal(8)]  [RED("cameraParallaxWeight")] public CFloat CameraParallaxWeight { get; set; }
		[Ordinal(9)]  [RED("cameraParallaxSpace")] public CEnum<scnfppParallaxSpace> CameraParallaxSpace { get; set; }
		[Ordinal(10)]  [RED("vehicleProceduralCameraWeight")] public CFloat VehicleProceduralCameraWeight { get; set; }
		[Ordinal(11)]  [RED("yawLimitLeft")] public CFloat YawLimitLeft { get; set; }
		[Ordinal(12)]  [RED("yawLimitRight")] public CFloat YawLimitRight { get; set; }
		[Ordinal(13)]  [RED("pitchLimitTop")] public CFloat PitchLimitTop { get; set; }
		[Ordinal(14)]  [RED("pitchLimitBottom")] public CFloat PitchLimitBottom { get; set; }
		[Ordinal(15)]  [RED("genderSpecificParams")] public CArray<scnfppGenderSpecificParams> GenderSpecificParams { get; set; }

		public scnPlayFPPControlAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
