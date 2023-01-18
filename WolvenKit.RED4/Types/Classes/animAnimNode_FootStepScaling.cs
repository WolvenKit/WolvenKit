using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FootStepScaling : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("hipsIndex")] 
		public animTransformIndex HipsIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("leftFootIKIndex")] 
		public animTransformIndex LeftFootIKIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("rightFootIKIndex")] 
		public animTransformIndex RightFootIKIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(15)] 
		[RED("inputSpeed")] 
		public animFloatLink InputSpeed
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(16)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(17)] 
		[RED("Params")] 
		public animfssBodyOfflineParams Params
		{
			get => GetPropertyValue<animfssBodyOfflineParams>();
			set => SetPropertyValue<animfssBodyOfflineParams>(value);
		}

		public animAnimNode_FootStepScaling()
		{
			Id = 4294967295;
			InputLink = new();
			HipsIndex = new();
			LeftFootIKIndex = new();
			RightFootIKIndex = new();
			InputSpeed = new();
			Weight = new();
			Params = new() { HipsTilt = 25.000000F, HipsShift = 0.100000F, LegsPullFactorMin = 0.050000F, LegsPullFactorMax = 0.165000F, LegLengthAdjustment = 0.005000F, LegMaxStretchOffset = 0.050000F, LegMaxStretchAdjustment = 0.015000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
