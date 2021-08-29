using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CMaterialParameterScalar : CMaterialParameter
	{
		private CFloat _scalar;
		private CFloat _min;
		private CFloat _max;

		[Ordinal(2)] 
		[RED("scalar")] 
		public CFloat Scalar
		{
			get => GetProperty(ref _scalar);
			set => SetProperty(ref _scalar, value);
		}

		[Ordinal(3)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(4)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}
	}
}
