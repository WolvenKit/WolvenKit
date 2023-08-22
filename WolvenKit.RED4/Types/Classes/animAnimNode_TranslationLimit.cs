using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TranslationLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("parentTransform")] 
		public animTransformIndex ParentTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("limitOnXAxis")] 
		public animFloatClamp LimitOnXAxis
		{
			get => GetPropertyValue<animFloatClamp>();
			set => SetPropertyValue<animFloatClamp>(value);
		}

		[Ordinal(15)] 
		[RED("limitOnYAxis")] 
		public animFloatClamp LimitOnYAxis
		{
			get => GetPropertyValue<animFloatClamp>();
			set => SetPropertyValue<animFloatClamp>(value);
		}

		[Ordinal(16)] 
		[RED("limitOnZAxis")] 
		public animFloatClamp LimitOnZAxis
		{
			get => GetPropertyValue<animFloatClamp>();
			set => SetPropertyValue<animFloatClamp>(value);
		}

		public animAnimNode_TranslationLimit()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			ConstrainedTransform = new animTransformIndex();
			ParentTransform = new animTransformIndex();
			LimitOnXAxis = new animFloatClamp { Min = -1.000000F, Max = 1.000000F };
			LimitOnYAxis = new animFloatClamp { Min = -1.000000F, Max = 1.000000F };
			LimitOnZAxis = new animFloatClamp { Min = -1.000000F, Max = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
