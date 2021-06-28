using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialPass : CVariable
	{
		private CName _stagePassNameRegular;
		private CName _stagePassNameDiscarded;
		private PSODescDepthStencilModeDesc _depthStencilMode;
		private PSODescRasterizerModeDesc _rasterizerMode;
		private PSODescBlendModeDesc _blendMode;
		private CUInt8 _stencilReadMask;
		private CUInt8 _stencilWriteMask;
		private CUInt8 _stencilRef;
		private CUInt8 _orderIndex;
		private CBool _enablePixelShader;

		[Ordinal(0)] 
		[RED("stagePassNameRegular")] 
		public CName StagePassNameRegular
		{
			get => GetProperty(ref _stagePassNameRegular);
			set => SetProperty(ref _stagePassNameRegular, value);
		}

		[Ordinal(1)] 
		[RED("stagePassNameDiscarded")] 
		public CName StagePassNameDiscarded
		{
			get => GetProperty(ref _stagePassNameDiscarded);
			set => SetProperty(ref _stagePassNameDiscarded, value);
		}

		[Ordinal(2)] 
		[RED("depthStencilMode")] 
		public PSODescDepthStencilModeDesc DepthStencilMode
		{
			get => GetProperty(ref _depthStencilMode);
			set => SetProperty(ref _depthStencilMode, value);
		}

		[Ordinal(3)] 
		[RED("rasterizerMode")] 
		public PSODescRasterizerModeDesc RasterizerMode
		{
			get => GetProperty(ref _rasterizerMode);
			set => SetProperty(ref _rasterizerMode, value);
		}

		[Ordinal(4)] 
		[RED("blendMode")] 
		public PSODescBlendModeDesc BlendMode
		{
			get => GetProperty(ref _blendMode);
			set => SetProperty(ref _blendMode, value);
		}

		[Ordinal(5)] 
		[RED("stencilReadMask")] 
		public CUInt8 StencilReadMask
		{
			get => GetProperty(ref _stencilReadMask);
			set => SetProperty(ref _stencilReadMask, value);
		}

		[Ordinal(6)] 
		[RED("stencilWriteMask")] 
		public CUInt8 StencilWriteMask
		{
			get => GetProperty(ref _stencilWriteMask);
			set => SetProperty(ref _stencilWriteMask, value);
		}

		[Ordinal(7)] 
		[RED("stencilRef")] 
		public CUInt8 StencilRef
		{
			get => GetProperty(ref _stencilRef);
			set => SetProperty(ref _stencilRef, value);
		}

		[Ordinal(8)] 
		[RED("orderIndex")] 
		public CUInt8 OrderIndex
		{
			get => GetProperty(ref _orderIndex);
			set => SetProperty(ref _orderIndex, value);
		}

		[Ordinal(9)] 
		[RED("enablePixelShader")] 
		public CBool EnablePixelShader
		{
			get => GetProperty(ref _enablePixelShader);
			set => SetProperty(ref _enablePixelShader, value);
		}

		public MaterialPass(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
