using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MaterialPass : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stagePassNameRegular")] 
		public CName StagePassNameRegular
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("stagePassNameDiscarded")] 
		public CName StagePassNameDiscarded
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("depthStencilMode")] 
		public PSODescDepthStencilModeDesc DepthStencilMode
		{
			get => GetPropertyValue<PSODescDepthStencilModeDesc>();
			set => SetPropertyValue<PSODescDepthStencilModeDesc>(value);
		}

		[Ordinal(3)] 
		[RED("rasterizerMode")] 
		public PSODescRasterizerModeDesc RasterizerMode
		{
			get => GetPropertyValue<PSODescRasterizerModeDesc>();
			set => SetPropertyValue<PSODescRasterizerModeDesc>(value);
		}

		[Ordinal(4)] 
		[RED("blendMode")] 
		public PSODescBlendModeDesc BlendMode
		{
			get => GetPropertyValue<PSODescBlendModeDesc>();
			set => SetPropertyValue<PSODescBlendModeDesc>(value);
		}

		[Ordinal(5)] 
		[RED("stencilReadMask")] 
		public CUInt8 StencilReadMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("stencilWriteMask")] 
		public CUInt8 StencilWriteMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("stencilRef")] 
		public CUInt8 StencilRef
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(8)] 
		[RED("orderIndex")] 
		public CUInt8 OrderIndex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(9)] 
		[RED("enablePixelShader")] 
		public CBool EnablePixelShader
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MaterialPass()
		{
			DepthStencilMode = new PSODescDepthStencilModeDesc { FrontFace = new PSODescStencilFuncDesc() };
			RasterizerMode = new PSODescRasterizerModeDesc();
			BlendMode = new PSODescBlendModeDesc { NumTargets = 1, RenderTarget = new(8) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
