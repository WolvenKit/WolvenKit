using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RotationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("limitOnX")] 
		public animSmoothFloatClamp LimitOnX
		{
			get => GetPropertyValue<animSmoothFloatClamp>();
			set => SetPropertyValue<animSmoothFloatClamp>(value);
		}

		[Ordinal(14)] 
		[RED("limitOnY")] 
		public animSmoothFloatClamp LimitOnY
		{
			get => GetPropertyValue<animSmoothFloatClamp>();
			set => SetPropertyValue<animSmoothFloatClamp>(value);
		}

		[Ordinal(15)] 
		[RED("limitOnZ")] 
		public animSmoothFloatClamp LimitOnZ
		{
			get => GetPropertyValue<animSmoothFloatClamp>();
			set => SetPropertyValue<animSmoothFloatClamp>(value);
		}

		[Ordinal(16)] 
		[RED("useEyesLookAtBlendWeight")] 
		public CBool UseEyesLookAtBlendWeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_RotationLimit()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			ConstrainedTransform = new animTransformIndex();
			LimitOnX = new animSmoothFloatClamp { Min = -1.000000F, Max = 1.000000F };
			LimitOnY = new animSmoothFloatClamp { Min = -1.000000F, Max = 1.000000F };
			LimitOnZ = new animSmoothFloatClamp { Min = -1.000000F, Max = 1.000000F };
			WeightLink = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
