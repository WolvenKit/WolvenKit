using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_QuaternionInterpolation : animAnimNode_QuaternionValue
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
		public animQuaternionLink FirstInput
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(13)] 
		[RED("secondInput")] 
		public animQuaternionLink SecondInput
		{
			get => GetPropertyValue<animQuaternionLink>();
			set => SetPropertyValue<animQuaternionLink>(value);
		}

		[Ordinal(14)] 
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
