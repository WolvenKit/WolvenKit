using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TransformInterpolation : animAnimNode_TransformValue
	{
		[Ordinal(11)] 
		[RED("interpolationType")] 
		public CEnum<animQuaternionInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<animQuaternionInterpolationType>>();
			set => SetPropertyValue<CEnum<animQuaternionInterpolationType>>(value);
		}

		[Ordinal(12)] 
		[RED("firstInput")] 
		public animTransformLink FirstInput
		{
			get => GetPropertyValue<animTransformLink>();
			set => SetPropertyValue<animTransformLink>(value);
		}

		[Ordinal(13)] 
		[RED("secondInput")] 
		public animTransformLink SecondInput
		{
			get => GetPropertyValue<animTransformLink>();
			set => SetPropertyValue<animTransformLink>(value);
		}

		[Ordinal(14)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_TransformInterpolation()
		{
			Id = 4294967295;
			InterpolationType = Enums.animQuaternionInterpolationType.Spherical;
			FirstInput = new();
			SecondInput = new();
			Weight = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
