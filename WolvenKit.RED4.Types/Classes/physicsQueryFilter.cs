using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsQueryFilter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("mask1")] 
		public CUInt64 Mask1
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("mask2")] 
		public CUInt64 Mask2
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public physicsQueryFilter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
