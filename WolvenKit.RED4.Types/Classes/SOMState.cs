using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SOMState : RedBaseClass
	{
		private PSODescDepthStencilModeDesc _depthStencilModeDesc;
		private PSODescRasterizerModeDesc _rasterizerModeDesc;
		private PSODescBlendModeDesc _blendModeDesc;
		private CUInt8 _stencilReadMask;
		private CUInt8 _stencilWriteMask;
		private CUInt8 _stencilRef;

		[Ordinal(0)] 
		[RED("depthStencilModeDesc")] 
		public PSODescDepthStencilModeDesc DepthStencilModeDesc
		{
			get => GetProperty(ref _depthStencilModeDesc);
			set => SetProperty(ref _depthStencilModeDesc, value);
		}

		[Ordinal(1)] 
		[RED("rasterizerModeDesc")] 
		public PSODescRasterizerModeDesc RasterizerModeDesc
		{
			get => GetProperty(ref _rasterizerModeDesc);
			set => SetProperty(ref _rasterizerModeDesc, value);
		}

		[Ordinal(2)] 
		[RED("blendModeDesc")] 
		public PSODescBlendModeDesc BlendModeDesc
		{
			get => GetProperty(ref _blendModeDesc);
			set => SetProperty(ref _blendModeDesc, value);
		}

		[Ordinal(3)] 
		[RED("stencilReadMask")] 
		public CUInt8 StencilReadMask
		{
			get => GetProperty(ref _stencilReadMask);
			set => SetProperty(ref _stencilReadMask, value);
		}

		[Ordinal(4)] 
		[RED("stencilWriteMask")] 
		public CUInt8 StencilWriteMask
		{
			get => GetProperty(ref _stencilWriteMask);
			set => SetProperty(ref _stencilWriteMask, value);
		}

		[Ordinal(5)] 
		[RED("stencilRef")] 
		public CUInt8 StencilRef
		{
			get => GetProperty(ref _stencilRef);
			set => SetProperty(ref _stencilRef, value);
		}
	}
}
