using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class garmentHiddenTrianglesRemovalParams : RedBaseClass
	{
		private CFloat _garmentBorderThreshold;
		private CBool _removeHiddenTriangles;
		private CBool _removeHiddenTrianglesRasterization;
		private CFloat _rayLengthInCM;
		private CFloat _rayLengthMorphOffsetFactor;

		[Ordinal(0)] 
		[RED("garmentBorderThreshold")] 
		public CFloat GarmentBorderThreshold
		{
			get => GetProperty(ref _garmentBorderThreshold);
			set => SetProperty(ref _garmentBorderThreshold, value);
		}

		[Ordinal(1)] 
		[RED("removeHiddenTriangles")] 
		public CBool RemoveHiddenTriangles
		{
			get => GetProperty(ref _removeHiddenTriangles);
			set => SetProperty(ref _removeHiddenTriangles, value);
		}

		[Ordinal(2)] 
		[RED("removeHiddenTrianglesRasterization")] 
		public CBool RemoveHiddenTrianglesRasterization
		{
			get => GetProperty(ref _removeHiddenTrianglesRasterization);
			set => SetProperty(ref _removeHiddenTrianglesRasterization, value);
		}

		[Ordinal(3)] 
		[RED("rayLengthInCM")] 
		public CFloat RayLengthInCM
		{
			get => GetProperty(ref _rayLengthInCM);
			set => SetProperty(ref _rayLengthInCM, value);
		}

		[Ordinal(4)] 
		[RED("rayLengthMorphOffsetFactor")] 
		public CFloat RayLengthMorphOffsetFactor
		{
			get => GetProperty(ref _rayLengthMorphOffsetFactor);
			set => SetProperty(ref _rayLengthMorphOffsetFactor, value);
		}

		public garmentHiddenTrianglesRemovalParams()
		{
			_garmentBorderThreshold = 0.650000F;
			_removeHiddenTriangles = true;
			_rayLengthInCM = 10.000000F;
			_rayLengthMorphOffsetFactor = 1.000000F;
		}
	}
}
