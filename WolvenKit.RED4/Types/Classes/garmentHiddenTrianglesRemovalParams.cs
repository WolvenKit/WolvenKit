using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class garmentHiddenTrianglesRemovalParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("garmentBorderThreshold")] 
		public CFloat GarmentBorderThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("removeHiddenTriangles")] 
		public CBool RemoveHiddenTriangles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("removeHiddenTrianglesRasterization")] 
		public CBool RemoveHiddenTrianglesRasterization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("rayLengthInCM")] 
		public CFloat RayLengthInCM
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("rayLengthMorphOffsetFactor")] 
		public CFloat RayLengthMorphOffsetFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public garmentHiddenTrianglesRemovalParams()
		{
			GarmentBorderThreshold = 0.650000F;
			RemoveHiddenTriangles = true;
			RayLengthInCM = 10.000000F;
			RayLengthMorphOffsetFactor = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
