using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSODescDepthStencilModeDesc : RedBaseClass
	{
		private CBool _depthTestEnable;
		private CBool _depthWriteEnable;
		private CEnum<PSODescDepthStencilModeComparisonMode> _depthFunc;
		private CBool _stencilEnable;
		private CBool _stencilReadMask;
		private CBool _stencilWriteMask;
		private PSODescStencilFuncDesc _frontFace;

		[Ordinal(0)] 
		[RED("depthTestEnable")] 
		public CBool DepthTestEnable
		{
			get => GetProperty(ref _depthTestEnable);
			set => SetProperty(ref _depthTestEnable, value);
		}

		[Ordinal(1)] 
		[RED("depthWriteEnable")] 
		public CBool DepthWriteEnable
		{
			get => GetProperty(ref _depthWriteEnable);
			set => SetProperty(ref _depthWriteEnable, value);
		}

		[Ordinal(2)] 
		[RED("depthFunc")] 
		public CEnum<PSODescDepthStencilModeComparisonMode> DepthFunc
		{
			get => GetProperty(ref _depthFunc);
			set => SetProperty(ref _depthFunc, value);
		}

		[Ordinal(3)] 
		[RED("stencilEnable")] 
		public CBool StencilEnable
		{
			get => GetProperty(ref _stencilEnable);
			set => SetProperty(ref _stencilEnable, value);
		}

		[Ordinal(4)] 
		[RED("stencilReadMask")] 
		public CBool StencilReadMask
		{
			get => GetProperty(ref _stencilReadMask);
			set => SetProperty(ref _stencilReadMask, value);
		}

		[Ordinal(5)] 
		[RED("stencilWriteMask")] 
		public CBool StencilWriteMask
		{
			get => GetProperty(ref _stencilWriteMask);
			set => SetProperty(ref _stencilWriteMask, value);
		}

		[Ordinal(6)] 
		[RED("frontFace")] 
		public PSODescStencilFuncDesc FrontFace
		{
			get => GetProperty(ref _frontFace);
			set => SetProperty(ref _frontFace, value);
		}
	}
}
