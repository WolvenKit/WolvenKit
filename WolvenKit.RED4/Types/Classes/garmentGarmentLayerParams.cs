using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class garmentGarmentLayerParams : CResource
	{
		[Ordinal(1)] 
		[RED("bending")] 
		public garmentBendingParams Bending
		{
			get => GetPropertyValue<garmentBendingParams>();
			set => SetPropertyValue<garmentBendingParams>(value);
		}

		[Ordinal(2)] 
		[RED("smoothing")] 
		public garmentSmoothingParams Smoothing
		{
			get => GetPropertyValue<garmentSmoothingParams>();
			set => SetPropertyValue<garmentSmoothingParams>(value);
		}

		[Ordinal(3)] 
		[RED("collarArea")] 
		public garmentCollarAreaParams CollarArea
		{
			get => GetPropertyValue<garmentCollarAreaParams>();
			set => SetPropertyValue<garmentCollarAreaParams>(value);
		}

		[Ordinal(4)] 
		[RED("hiddenTrianglesRemoval")] 
		public garmentHiddenTrianglesRemovalParams HiddenTrianglesRemoval
		{
			get => GetPropertyValue<garmentHiddenTrianglesRemovalParams>();
			set => SetPropertyValue<garmentHiddenTrianglesRemovalParams>(value);
		}

		public garmentGarmentLayerParams()
		{
			Bending = new() { BendPowerOffsetInCM = 1.000000F };
			Smoothing = new() { SmoothingRadiusInCM = 15.000000F, SmoothingExponent = 0.500000F, SmoothingNumNeighbours = 4 };
			CollarArea = new() { RadiusInCM = 32.000000F, RadiusForTriangleRemovalInCM = 16.000000F, Offset = new() };
			HiddenTrianglesRemoval = new() { GarmentBorderThreshold = 0.650000F, RemoveHiddenTriangles = true, RayLengthInCM = 10.000000F, RayLengthMorphOffsetFactor = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
