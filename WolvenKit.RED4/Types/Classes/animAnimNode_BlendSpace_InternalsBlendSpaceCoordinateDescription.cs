using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("minValue")] 
		public CFloat MinValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("gridDivisionsCount")] 
		public CUInt32 GridDivisionsCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription()
		{
			MaxValue = 1.000000F;
			GridDivisionsCount = 4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
