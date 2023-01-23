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
