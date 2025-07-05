using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_VectorInterpolation : animAnimNode_VectorValue
	{
		[Ordinal(11)] 
		[RED("firstInput")] 
		public animVectorLink FirstInput
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(12)] 
		[RED("secondInput")] 
		public animVectorLink SecondInput
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(13)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_VectorInterpolation()
		{
			Id = uint.MaxValue;
			FirstInput = new animVectorLink();
			SecondInput = new animVectorLink();
			Weight = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
