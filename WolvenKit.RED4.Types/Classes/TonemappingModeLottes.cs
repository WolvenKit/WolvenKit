using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TonemappingModeLottes : ITonemappingMode
	{
		private CFloat _maxInput;
		private CFloat _contrast;
		private CFloat _midIn;
		private CFloat _midOut;
		private Vector3 _crosstalk;
		private Vector3 _crosstalkSaturation;

		[Ordinal(1)] 
		[RED("maxInput")] 
		public CFloat MaxInput
		{
			get => GetProperty(ref _maxInput);
			set => SetProperty(ref _maxInput, value);
		}

		[Ordinal(2)] 
		[RED("contrast")] 
		public CFloat Contrast
		{
			get => GetProperty(ref _contrast);
			set => SetProperty(ref _contrast, value);
		}

		[Ordinal(3)] 
		[RED("midIn")] 
		public CFloat MidIn
		{
			get => GetProperty(ref _midIn);
			set => SetProperty(ref _midIn, value);
		}

		[Ordinal(4)] 
		[RED("midOut")] 
		public CFloat MidOut
		{
			get => GetProperty(ref _midOut);
			set => SetProperty(ref _midOut, value);
		}

		[Ordinal(5)] 
		[RED("crosstalk")] 
		public Vector3 Crosstalk
		{
			get => GetProperty(ref _crosstalk);
			set => SetProperty(ref _crosstalk, value);
		}

		[Ordinal(6)] 
		[RED("crosstalkSaturation")] 
		public Vector3 CrosstalkSaturation
		{
			get => GetProperty(ref _crosstalkSaturation);
			set => SetProperty(ref _crosstalkSaturation, value);
		}
	}
}
