using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDistantGINode : worldNode
	{
		[Ordinal(4)] 
		[RED("dataAlbedo")] 
		public CResourceAsyncReference<CBitmapTexture> DataAlbedo
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(5)] 
		[RED("dataNormal")] 
		public CResourceAsyncReference<CBitmapTexture> DataNormal
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(6)] 
		[RED("dataHeight")] 
		public CResourceAsyncReference<CBitmapTexture> DataHeight
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(7)] 
		[RED("sectorSpan")] 
		public Vector4 SectorSpan
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public worldDistantGINode()
		{
			SectorSpan = new Vector4 { X = -1.000000F, Y = -1.000000F, Z = 1.000000F, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
