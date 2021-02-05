using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_FPPCamera : animAnimFeature
	{
		[Ordinal(0)]  [RED("fov")] public CFloat Fov { get; set; }
		[Ordinal(1)]  [RED("deltaYaw")] public CFloat DeltaYaw { get; set; }
		[Ordinal(2)]  [RED("deltaYawExternal")] public CFloat DeltaYawExternal { get; set; }
		[Ordinal(3)]  [RED("deltaYawInput")] public CFloat DeltaYawInput { get; set; }
		[Ordinal(4)]  [RED("yawSpeed")] public CFloat YawSpeed { get; set; }
		[Ordinal(5)]  [RED("yawMaxLeft")] public CFloat YawMaxLeft { get; set; }
		[Ordinal(6)]  [RED("yawMaxRight")] public CFloat YawMaxRight { get; set; }
		[Ordinal(7)]  [RED("deltaPitch")] public CFloat DeltaPitch { get; set; }
		[Ordinal(8)]  [RED("deltaPitchExternal")] public CFloat DeltaPitchExternal { get; set; }
		[Ordinal(9)]  [RED("deltaPitchInput")] public CFloat DeltaPitchInput { get; set; }
		[Ordinal(10)]  [RED("pitchSpeed")] public CFloat PitchSpeed { get; set; }
		[Ordinal(11)]  [RED("pitchMin")] public CFloat PitchMin { get; set; }
		[Ordinal(12)]  [RED("pitchMax")] public CFloat PitchMax { get; set; }
		[Ordinal(13)]  [RED("resetYawSpeed")] public CFloat ResetYawSpeed { get; set; }
		[Ordinal(14)]  [RED("resetPitchSpeed")] public CFloat ResetPitchSpeed { get; set; }
		[Ordinal(15)]  [RED("resetExternalsSpeed")] public CFloat ResetExternalsSpeed { get; set; }
		[Ordinal(16)]  [RED("isSceneMode")] public CBool IsSceneMode { get; set; }
		[Ordinal(17)]  [RED("t4Blend")] public CFloat T4Blend { get; set; }
		[Ordinal(18)]  [RED("t4Pitch")] public CFloat T4Pitch { get; set; }
		[Ordinal(19)]  [RED("t4Yaw")] public CFloat T4Yaw { get; set; }
		[Ordinal(20)]  [RED("t4Roll")] public CFloat T4Roll { get; set; }
		[Ordinal(21)]  [RED("t4CopyPitchAndYaw")] public CBool T4CopyPitchAndYaw { get; set; }
		[Ordinal(22)]  [RED("sceneCameraUseTrajectorySpace")] public CBool SceneCameraUseTrajectorySpace { get; set; }
		[Ordinal(23)]  [RED("sceneTransitioningToGameplay")] public CBool SceneTransitioningToGameplay { get; set; }
		[Ordinal(24)]  [RED("yawMultiplier")] public CFloat YawMultiplier { get; set; }
		[Ordinal(25)]  [RED("pitchMultiplier")] public CFloat PitchMultiplier { get; set; }
		[Ordinal(26)]  [RED("overridePitchInput")] public CFloat OverridePitchInput { get; set; }
		[Ordinal(27)]  [RED("overridePitchRef")] public CFloat OverridePitchRef { get; set; }
		[Ordinal(28)]  [RED("overrideYawInput")] public CFloat OverrideYawInput { get; set; }
		[Ordinal(29)]  [RED("overrideYawRef")] public CFloat OverrideYawRef { get; set; }
		[Ordinal(30)]  [RED("override")] public CFloat Override { get; set; }
		[Ordinal(31)]  [RED("parallaxSide")] public CFloat ParallaxSide { get; set; }
		[Ordinal(32)]  [RED("parallaxForward")] public CFloat ParallaxForward { get; set; }
		[Ordinal(33)]  [RED("parallaxSpace")] public CFloat ParallaxSpace { get; set; }
		[Ordinal(34)]  [RED("normalizeYaw")] public CBool NormalizeYaw { get; set; }
		[Ordinal(35)]  [RED("vehicleOffsetWeight")] public CFloat VehicleOffsetWeight { get; set; }
		[Ordinal(36)]  [RED("gameplayCameraPoseWeight")] public CFloat GameplayCameraPoseWeight { get; set; }
		[Ordinal(37)]  [RED("additiveCameraMovementsWeight")] public CFloat AdditiveCameraMovementsWeight { get; set; }
		[Ordinal(38)]  [RED("vehicleProceduralCameraWeight")] public CFloat VehicleProceduralCameraWeight { get; set; }
		[Ordinal(39)]  [RED("t4CameraIdleOrientation")] public Quaternion T4CameraIdleOrientation { get; set; }
		[Ordinal(40)]  [RED("t4UseCameraIdleOrientation")] public CBool T4UseCameraIdleOrientation { get; set; }
		[Ordinal(41)]  [RED("t4CameraControlIdleOrientation")] public Quaternion T4CameraControlIdleOrientation { get; set; }

		public animAnimFeature_FPPCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
