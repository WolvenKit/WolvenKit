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
			Bending = new garmentBendingParams();
			Smoothing = new garmentSmoothingParams();
			CollarArea = new garmentCollarAreaParams();
			HiddenTrianglesRemoval = new garmentHiddenTrianglesRemovalParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
