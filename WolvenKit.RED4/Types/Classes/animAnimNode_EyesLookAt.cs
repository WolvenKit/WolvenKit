using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_EyesLookAt : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("targetALink")] 
		public animVectorLink TargetALink
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(13)] 
		[RED("weightALink")] 
		public animFloatLink WeightALink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(14)] 
		[RED("targetBLink")] 
		public animVectorLink TargetBLink
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(15)] 
		[RED("weightBLink")] 
		public animFloatLink WeightBLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(16)] 
		[RED("transitionWeightLink")] 
		public animFloatLink TransitionWeightLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(17)] 
		[RED("leftEye")] 
		public animTransformIndex LeftEye
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(18)] 
		[RED("rightEye")] 
		public animTransformIndex RightEye
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(19)] 
		[RED("head")] 
		public animTransformIndex Head
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(20)] 
		[RED("forwardDirection")] 
		public CEnum<animAxis> ForwardDirection
		{
			get => GetPropertyValue<CEnum<animAxis>>();
			set => SetPropertyValue<CEnum<animAxis>>(value);
		}

		public animAnimNode_EyesLookAt()
		{
			Id = 4294967295;
			InputLink = new();
			TargetALink = new();
			WeightALink = new();
			TargetBLink = new();
			WeightBLink = new();
			TransitionWeightLink = new();
			LeftEye = new();
			RightEye = new();
			Head = new();
			ForwardDirection = Enums.animAxis.NegativeY;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
