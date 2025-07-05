using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_PointConstraint_WeightedTransform : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_PointConstraint_WeightedTransform()
		{
			Transform = new animTransformIndex();
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
