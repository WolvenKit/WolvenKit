using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDistantGINode : worldNode
	{
		private CResourceAsyncReference<CBitmapTexture> _dataAlbedo;
		private CResourceAsyncReference<CBitmapTexture> _dataNormal;
		private CResourceAsyncReference<CBitmapTexture> _dataHeight;
		private Vector4 _sectorSpan;

		[Ordinal(4)] 
		[RED("dataAlbedo")] 
		public CResourceAsyncReference<CBitmapTexture> DataAlbedo
		{
			get => GetProperty(ref _dataAlbedo);
			set => SetProperty(ref _dataAlbedo, value);
		}

		[Ordinal(5)] 
		[RED("dataNormal")] 
		public CResourceAsyncReference<CBitmapTexture> DataNormal
		{
			get => GetProperty(ref _dataNormal);
			set => SetProperty(ref _dataNormal, value);
		}

		[Ordinal(6)] 
		[RED("dataHeight")] 
		public CResourceAsyncReference<CBitmapTexture> DataHeight
		{
			get => GetProperty(ref _dataHeight);
			set => SetProperty(ref _dataHeight, value);
		}

		[Ordinal(7)] 
		[RED("sectorSpan")] 
		public Vector4 SectorSpan
		{
			get => GetProperty(ref _sectorSpan);
			set => SetProperty(ref _sectorSpan, value);
		}
	}
}
