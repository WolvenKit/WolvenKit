using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCurvePathNode : worldSplineNode
	{
		[Ordinal(9)] 
		[RED("userInput")] 
		public animCurvePathBakerUserInput UserInput
		{
			get => GetPropertyValue<animCurvePathBakerUserInput>();
			set => SetPropertyValue<animCurvePathBakerUserInput>(value);
		}

		[Ordinal(10)] 
		[RED("defaultForwardVector")] 
		public Vector4 DefaultForwardVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(11)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("defaultPoseAnimationName")] 
		public CName DefaultPoseAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("defaultPoseSampleTime")] 
		public CFloat DefaultPoseSampleTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("initialDiffYaw")] 
		public CFloat InitialDiffYaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("rig")] 
		public CResourceReference<animRig> Rig
		{
			get => GetPropertyValue<CResourceReference<animRig>>();
			set => SetPropertyValue<CResourceReference<animRig>>(value);
		}

		[Ordinal(18)] 
		[RED("animSets")] 
		public CArray<CResourceReference<animAnimSet>> AnimSets
		{
			get => GetPropertyValue<CArray<CResourceReference<animAnimSet>>>();
			set => SetPropertyValue<CArray<CResourceReference<animAnimSet>>>(value);
		}

		[Ordinal(19)] 
		[RED("timeDeltaMultiplier")] 
		public CFloat TimeDeltaMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldCurvePathNode()
		{
			UserInput = new();
			DefaultForwardVector = new() { Y = 1.000000F };
			GlobalInBlendTime = 0.200000F;
			GlobalOutBlendTime = 0.200000F;
			TurnCharacterToMatchVelocity = true;
			AnimSets = new();
			TimeDeltaMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
