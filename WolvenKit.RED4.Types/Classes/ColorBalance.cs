using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ColorBalance : RedBaseClass
	{
		private CFloat _red;
		private CFloat _green;
		private CFloat _blue;
		private CFloat _luminance;

		[Ordinal(0)] 
		[RED("Red")] 
		public CFloat Red
		{
			get => GetProperty(ref _red);
			set => SetProperty(ref _red, value);
		}

		[Ordinal(1)] 
		[RED("Green")] 
		public CFloat Green
		{
			get => GetProperty(ref _green);
			set => SetProperty(ref _green, value);
		}

		[Ordinal(2)] 
		[RED("Blue")] 
		public CFloat Blue
		{
			get => GetProperty(ref _blue);
			set => SetProperty(ref _blue, value);
		}

		[Ordinal(3)] 
		[RED("Luminance")] 
		public CFloat Luminance
		{
			get => GetProperty(ref _luminance);
			set => SetProperty(ref _luminance, value);
		}
	}
}
