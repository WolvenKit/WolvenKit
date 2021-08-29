using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkInnerGlowEffect : inkIEffect
	{
		private CFloat _colorR;
		private CFloat _colorG;
		private CFloat _colorB;
		private CFloat _colorA;
		private CFloat _offsetX;
		private CFloat _offsetY;

		[Ordinal(2)] 
		[RED("colorR")] 
		public CFloat ColorR
		{
			get => GetProperty(ref _colorR);
			set => SetProperty(ref _colorR, value);
		}

		[Ordinal(3)] 
		[RED("colorG")] 
		public CFloat ColorG
		{
			get => GetProperty(ref _colorG);
			set => SetProperty(ref _colorG, value);
		}

		[Ordinal(4)] 
		[RED("colorB")] 
		public CFloat ColorB
		{
			get => GetProperty(ref _colorB);
			set => SetProperty(ref _colorB, value);
		}

		[Ordinal(5)] 
		[RED("colorA")] 
		public CFloat ColorA
		{
			get => GetProperty(ref _colorA);
			set => SetProperty(ref _colorA, value);
		}

		[Ordinal(6)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get => GetProperty(ref _offsetX);
			set => SetProperty(ref _offsetX, value);
		}

		[Ordinal(7)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get => GetProperty(ref _offsetY);
			set => SetProperty(ref _offsetY, value);
		}
	}
}
