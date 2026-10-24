using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RotationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("limitOnX")] 
		public animSmoothFloatClamp LimitOnX
		{
			get => GetPropertyValue<animSmoothFloatClamp>();
			set => SetPropertyValue<animSmoothFloatClamp>(value);
		}

		[Ordinal(4)] 
		[RED("limitOnY")] 
		public animSmoothFloatClamp LimitOnY
		{
			get => GetPropertyValue<animSmoothFloatClamp>();
			set => SetPropertyValue<animSmoothFloatClamp>(value);
		}

		[Ordinal(5)] 
		[RED("limitOnZ")] 
		public animSmoothFloatClamp LimitOnZ
		{
			get => GetPropertyValue<animSmoothFloatClamp>();
			set => SetPropertyValue<animSmoothFloatClamp>(value);
		}

		[Ordinal(6)] 
		[RED("useEyesLookAtBlendWeight")] 
		public CBool UseEyesLookAtBlendWeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
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
			LimitOnX = new animSmoothFloatClamp();
			LimitOnY = new animSmoothFloatClamp();
			LimitOnZ = new animSmoothFloatClamp();
			WeightLink = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
