using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SOMState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("depthStencilModeDesc")] 
		public PSODescDepthStencilModeDesc DepthStencilModeDesc
		{
			get => GetPropertyValue<PSODescDepthStencilModeDesc>();
			set => SetPropertyValue<PSODescDepthStencilModeDesc>(value);
		}

		[Ordinal(1)] 
		[RED("rasterizerModeDesc")] 
		public PSODescRasterizerModeDesc RasterizerModeDesc
		{
			get => GetPropertyValue<PSODescRasterizerModeDesc>();
			set => SetPropertyValue<PSODescRasterizerModeDesc>(value);
		}

		[Ordinal(2)] 
		[RED("blendModeDesc")] 
		public PSODescBlendModeDesc BlendModeDesc
		{
			get => GetPropertyValue<PSODescBlendModeDesc>();
			set => SetPropertyValue<PSODescBlendModeDesc>(value);
		}

		[Ordinal(3)] 
		[RED("stencilReadMask")] 
		public CUInt8 StencilReadMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("stencilWriteMask")] 
		public CUInt8 StencilWriteMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(5)] 
		[RED("stencilRef")] 
		public CUInt8 StencilRef
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public SOMState()
		{
			DepthStencilModeDesc = new PSODescDepthStencilModeDesc { DepthTestEnable = true, DepthWriteEnable = true, DepthFunc = Enums.PSODescDepthStencilModeComparisonMode.COMPARISON_LessEqual, StencilEnable = true, FrontFace = new PSODescStencilFuncDesc { StencilFunc = Enums.PSODescDepthStencilModeComparisonMode.COMPARISON_LessEqual } };
			RasterizerModeDesc = new PSODescRasterizerModeDesc { FrontWinding = Enums.PSODescRasterizerModeFrontFaceWinding.FRONTFACE_CW, CullMode = Enums.PSODescRasterizerModeCullMode.CULL_Back };
			BlendModeDesc = new PSODescBlendModeDesc { NumTargets = 1, RenderTarget = new(8) };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
