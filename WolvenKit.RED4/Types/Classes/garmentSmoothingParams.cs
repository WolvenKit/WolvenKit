using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class garmentSmoothingParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("smoothingStrength")] 
		public CFloat SmoothingStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("smoothingRadiusInCM")] 
		public CFloat SmoothingRadiusInCM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("smoothingExponent")] 
		public CFloat SmoothingExponent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("smoothingNumNeighbours")] 
		public CUInt32 SmoothingNumNeighbours
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("smoothNormalsEnabled")] 
		public CBool SmoothNormalsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public garmentSmoothingParams()
		{
			SmoothingRadiusInCM = 15.000000F;
			SmoothingExponent = 0.500000F;
			SmoothingNumNeighbours = 4;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
