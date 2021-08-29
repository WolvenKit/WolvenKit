using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CBitmapTexture : ITexture
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CUInt32 _depth;
		private STextureGroupSetup _setup;
		private Vector3 _histBiasMulCoef;
		private Vector3 _histBiasAddCoef;
		private CHandle<IRenderResourceBlob> _renderResourceBlob;
		private rendRenderTextureResource _renderTextureResource;

		[Ordinal(1)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(3)] 
		[RED("depth")] 
		public CUInt32 Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}

		[Ordinal(4)] 
		[RED("setup")] 
		public STextureGroupSetup Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}

		[Ordinal(5)] 
		[RED("histBiasMulCoef")] 
		public Vector3 HistBiasMulCoef
		{
			get => GetProperty(ref _histBiasMulCoef);
			set => SetProperty(ref _histBiasMulCoef, value);
		}

		[Ordinal(6)] 
		[RED("histBiasAddCoef")] 
		public Vector3 HistBiasAddCoef
		{
			get => GetProperty(ref _histBiasAddCoef);
			set => SetProperty(ref _histBiasAddCoef, value);
		}

		[Ordinal(7)] 
		[RED("renderResourceBlob")] 
		public CHandle<IRenderResourceBlob> RenderResourceBlob
		{
			get => GetProperty(ref _renderResourceBlob);
			set => SetProperty(ref _renderResourceBlob, value);
		}

		[Ordinal(8)] 
		[RED("renderTextureResource")] 
		public rendRenderTextureResource RenderTextureResource
		{
			get => GetProperty(ref _renderTextureResource);
			set => SetProperty(ref _renderTextureResource, value);
		}
	}
}
