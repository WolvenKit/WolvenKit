using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PSODescStencilFuncDesc : RedBaseClass
	{
		private CEnum<PSODescDepthStencilModeStencilOpMode> _stencilPassOp;
		private CEnum<PSODescDepthStencilModeComparisonMode> _stencilFunc;

		[Ordinal(0)] 
		[RED("stencilPassOp")] 
		public CEnum<PSODescDepthStencilModeStencilOpMode> StencilPassOp
		{
			get => GetProperty(ref _stencilPassOp);
			set => SetProperty(ref _stencilPassOp, value);
		}

		[Ordinal(1)] 
		[RED("stencilFunc")] 
		public CEnum<PSODescDepthStencilModeComparisonMode> StencilFunc
		{
			get => GetProperty(ref _stencilFunc);
			set => SetProperty(ref _stencilFunc, value);
		}
	}
}
