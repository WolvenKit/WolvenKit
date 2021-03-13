using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayFPPControlAnimEvent : scnPlayAnimEvent
	{
		[Ordinal(15)] [RED("gameplayAnimName")] public CHandle<scnAnimName> GameplayAnimName { get; set; }
		[Ordinal(16)] [RED("FPPControlActive")] public CBool FPPControlActive { get; set; }
		[Ordinal(17)] [RED("blendOverride")] public CEnum<scnfppBlendOverride> BlendOverride { get; set; }
		[Ordinal(18)] [RED("cameraUseTrajectorySpace")] public CBool CameraUseTrajectorySpace { get; set; }
		[Ordinal(19)] [RED("cameraBlendInDuration")] public CFloat CameraBlendInDuration { get; set; }
		[Ordinal(20)] [RED("cameraBlendOutDuration")] public CFloat CameraBlendOutDuration { get; set; }
		[Ordinal(21)] [RED("stayInScene")] public CBool StayInScene { get; set; }
		[Ordinal(22)] [RED("idleIsMountedWorkspot")] public CBool IdleIsMountedWorkspot { get; set; }
		[Ordinal(23)] [RED("cameraParallaxWeight")] public CFloat CameraParallaxWeight { get; set; }
		[Ordinal(24)] [RED("cameraParallaxSpace")] public CEnum<scnfppParallaxSpace> CameraParallaxSpace { get; set; }
		[Ordinal(25)] [RED("vehicleProceduralCameraWeight")] public CFloat VehicleProceduralCameraWeight { get; set; }
		[Ordinal(26)] [RED("yawLimitLeft")] public CFloat YawLimitLeft { get; set; }
		[Ordinal(27)] [RED("yawLimitRight")] public CFloat YawLimitRight { get; set; }
		[Ordinal(28)] [RED("pitchLimitTop")] public CFloat PitchLimitTop { get; set; }
		[Ordinal(29)] [RED("pitchLimitBottom")] public CFloat PitchLimitBottom { get; set; }
		[Ordinal(30)] [RED("genderSpecificParams")] public CArray<scnfppGenderSpecificParams> GenderSpecificParams { get; set; }

		public scnPlayFPPControlAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
