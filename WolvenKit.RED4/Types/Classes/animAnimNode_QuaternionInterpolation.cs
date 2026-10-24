using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_QuaternionInterpolation : animAnimNode_QuaternionValue
	{
		[Ordinal(1)] 
		[RED("interpolationType")] 
		public CEnum<animQuaternionInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<animQuaternionInterpolationType>>();
			set => SetPropertyValue<CEnum<animQuaternionInterpolationType>>(value);
		}

		[Ordinal(2)] 
		[RED("firstInput")] 
		public animQuaternionLink FirstInput
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(3)] 
		[RED("secondInput")] 
		public animQuaternionLink SecondInput
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(4)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_QuaternionInterpolation()
		{
			Id = uint.MaxValue;
			InterpolationType = Enums.animQuaternionInterpolationType.Spherical;
			FirstInput = new animQuaternionLink();
			SecondInput = new animQuaternionLink();
			Weight = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
