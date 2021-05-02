using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSODescStencilFuncDesc : CVariable
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

		public PSODescStencilFuncDesc(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
