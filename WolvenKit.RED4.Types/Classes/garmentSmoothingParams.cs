using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class garmentSmoothingParams : RedBaseClass
	{
		private CFloat _smoothingStrength;
		private CFloat _smoothingRadiusInCM;
		private CFloat _smoothingExponent;
		private CUInt32 _smoothingNumNeighbours;

		[Ordinal(0)] 
		[RED("smoothingStrength")] 
		public CFloat SmoothingStrength
		{
			get => GetProperty(ref _smoothingStrength);
			set => SetProperty(ref _smoothingStrength, value);
		}

		[Ordinal(1)] 
		[RED("smoothingRadiusInCM")] 
		public CFloat SmoothingRadiusInCM
		{
			get => GetProperty(ref _smoothingRadiusInCM);
			set => SetProperty(ref _smoothingRadiusInCM, value);
		}

		[Ordinal(2)] 
		[RED("smoothingExponent")] 
		public CFloat SmoothingExponent
		{
			get => GetProperty(ref _smoothingExponent);
			set => SetProperty(ref _smoothingExponent, value);
		}

		[Ordinal(3)] 
		[RED("smoothingNumNeighbours")] 
		public CUInt32 SmoothingNumNeighbours
		{
			get => GetProperty(ref _smoothingNumNeighbours);
			set => SetProperty(ref _smoothingNumNeighbours, value);
		}
	}
}
