using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_OrientConstraint_WeightedTransform : RedBaseClass
	{
		private animTransformIndex _transform;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public animAnimNode_OrientConstraint_WeightedTransform()
		{
			_weight = 1.000000F;
		}
	}
}
