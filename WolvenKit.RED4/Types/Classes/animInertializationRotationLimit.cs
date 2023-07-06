using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animInertializationRotationLimit : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("limitOnX")] 
		public animInertializationFloatClamp LimitOnX
		{
			get => GetPropertyValue<animInertializationFloatClamp>();
			set => SetPropertyValue<animInertializationFloatClamp>(value);
		}

		[Ordinal(2)] 
		[RED("limitOnY")] 
		public animInertializationFloatClamp LimitOnY
		{
			get => GetPropertyValue<animInertializationFloatClamp>();
			set => SetPropertyValue<animInertializationFloatClamp>(value);
		}

		[Ordinal(3)] 
		[RED("limitOnZ")] 
		public animInertializationFloatClamp LimitOnZ
		{
			get => GetPropertyValue<animInertializationFloatClamp>();
			set => SetPropertyValue<animInertializationFloatClamp>(value);
		}

		public animInertializationRotationLimit()
		{
			ConstrainedTransform = new animTransformIndex();
			LimitOnX = new animInertializationFloatClamp { Min = -1.000000F, Max = 1.000000F };
			LimitOnY = new animInertializationFloatClamp { Min = -1.000000F, Max = 1.000000F };
			LimitOnZ = new animInertializationFloatClamp { Min = -1.000000F, Max = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
