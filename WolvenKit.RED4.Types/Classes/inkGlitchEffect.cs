using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkGlitchEffect : inkIEffect
	{
		private CFloat _intensity;
		private CFloat _offsetX;
		private CFloat _offsetY;
		private CFloat _sizeX;
		private CFloat _sizeY;

		[Ordinal(2)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get => GetProperty(ref _offsetX);
			set => SetProperty(ref _offsetX, value);
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get => GetProperty(ref _offsetY);
			set => SetProperty(ref _offsetY, value);
		}

		[Ordinal(5)] 
		[RED("sizeX")] 
		public CFloat SizeX
		{
			get => GetProperty(ref _sizeX);
			set => SetProperty(ref _sizeX, value);
		}

		[Ordinal(6)] 
		[RED("sizeY")] 
		public CFloat SizeY
		{
			get => GetProperty(ref _sizeY);
			set => SetProperty(ref _sizeY, value);
		}
	}
}
