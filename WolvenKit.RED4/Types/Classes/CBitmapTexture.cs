using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CBitmapTexture : ITexture
	{
		[Ordinal(1)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("depth")] 
		public CUInt32 Depth
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("setup")] 
		public STextureGroupSetup Setup
		{
			get => GetPropertyValue<STextureGroupSetup>();
			set => SetPropertyValue<STextureGroupSetup>(value);
		}

		[Ordinal(5)] 
		[RED("histBiasMulCoef")] 
		public Vector3 HistBiasMulCoef
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(6)] 
		[RED("histBiasAddCoef")] 
		public Vector3 HistBiasAddCoef
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(7)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}

		[Ordinal(8)] 
		[RED("renderTextureResource")] 
		public rendRenderTextureResource RenderTextureResource
		{
			get => GetPropertyValue<rendRenderTextureResource>();
			set => SetPropertyValue<rendRenderTextureResource>(value);
		}

		public CBitmapTexture()
		{
			Depth = 1;
			Setup = new STextureGroupSetup { Group = Enums.GpuWrapApieTextureGroup.TEXG_Generic_Color, RawFormat = Enums.ETextureRawFormat.TRF_TrueColor, IsStreamable = true, HasMipchain = true, AllowTextureDowngrade = true };
			HistBiasMulCoef = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			HistBiasAddCoef = new Vector3();
			RenderTextureResource = new rendRenderTextureResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
