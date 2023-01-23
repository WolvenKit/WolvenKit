using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSceneAnimationMotionActionParams : IScriptable
	{
		[Ordinal(0)] 
		[RED("motionType")] 
		public CEnum<gameSceneAnimationMotionActionParamsMotionType> MotionType
		{
			get => GetPropertyValue<CEnum<gameSceneAnimationMotionActionParamsMotionType>>();
			set => SetPropertyValue<CEnum<gameSceneAnimationMotionActionParamsMotionType>>(value);
		}

		[Ordinal(1)] 
		[RED("placementTransform")] 
		public WorldTransform PlacementTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(2)] 
		[RED("motionBlendInTime")] 
		public CFloat MotionBlendInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("poseBlendInTime")] 
		public CFloat PoseBlendInTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("blendInCurve")] 
		public CEnum<gameSceneAnimationMotionActionParamsEasingType> BlendInCurve
		{
			get => GetPropertyValue<CEnum<gameSceneAnimationMotionActionParamsEasingType>>();
			set => SetPropertyValue<CEnum<gameSceneAnimationMotionActionParamsEasingType>>(value);
		}

		[Ordinal(5)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("placementMode")] 
		public CEnum<gameSceneAnimationMotionActionParamsPlacementMode> PlacementMode
		{
			get => GetPropertyValue<CEnum<gameSceneAnimationMotionActionParamsPlacementMode>>();
			set => SetPropertyValue<CEnum<gameSceneAnimationMotionActionParamsPlacementMode>>(value);
		}

		[Ordinal(7)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("endTime")] 
		public CFloat EndTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("initialDt")] 
		public CFloat InitialDt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("globalTimeToAnimTime")] 
		public CFloat GlobalTimeToAnimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("mountDescriptor")] 
		public gameMountDescriptor MountDescriptor
		{
			get => GetPropertyValue<gameMountDescriptor>();
			set => SetPropertyValue<gameMountDescriptor>(value);
		}

		[Ordinal(12)] 
		[RED("playerParams")] 
		public gameScenePlayerAnimationParams PlayerParams
		{
			get => GetPropertyValue<gameScenePlayerAnimationParams>();
			set => SetPropertyValue<gameScenePlayerAnimationParams>(value);
		}

		[Ordinal(13)] 
		[RED("trajectoryLOD")] 
		public CArray<scnAnimationMotionSample> TrajectoryLOD
		{
			get => GetPropertyValue<CArray<scnAnimationMotionSample>>();
			set => SetPropertyValue<CArray<scnAnimationMotionSample>>(value);
		}

		[Ordinal(14)] 
		[RED("dynamicAnimSetupHash")] 
		public CUInt64 DynamicAnimSetupHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public gameSceneAnimationMotionActionParams()
		{
			PlacementTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			BlendInCurve = Enums.gameSceneAnimationMotionActionParamsEasingType.SinusoidalEaseInOut;
			GlobalTimeToAnimTime = 1.000000F;
			MountDescriptor = new() { ParentId = new(), InitialTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } }, MountType = Enums.gameMountDescriptorMountType.KeepState };
			PlayerParams = new();
			TrajectoryLOD = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
