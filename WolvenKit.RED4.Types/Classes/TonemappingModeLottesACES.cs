using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TonemappingModeLottesACES : ITonemappingMode
	{
		private CFloat _maxInput;
		private CFloat _contrast;
		private CFloat _midIn;
		private CFloat _midOut;

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

		public TonemappingModeLottesACES()
		{
			_maxInput = 50.000000F;
			_contrast = 1.500000F;
			_midIn = 0.180000F;
			_midOut = 0.180000F;
		}
	}
}
