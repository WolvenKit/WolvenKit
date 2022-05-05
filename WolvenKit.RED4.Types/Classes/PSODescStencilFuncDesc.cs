using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSODescStencilFuncDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stencilPassOp")] 
		public CEnum<PSODescDepthStencilModeStencilOpMode> StencilPassOp
		{
			get => GetPropertyValue<CEnum<PSODescDepthStencilModeStencilOpMode>>();
			set => SetPropertyValue<CEnum<PSODescDepthStencilModeStencilOpMode>>(value);
		}

		[Ordinal(1)] 
		[RED("stencilFunc")] 
		public CEnum<PSODescDepthStencilModeComparisonMode> StencilFunc
		{
			get => GetPropertyValue<CEnum<PSODescDepthStencilModeComparisonMode>>();
			set => SetPropertyValue<CEnum<PSODescDepthStencilModeComparisonMode>>(value);
		}

		public PSODescStencilFuncDesc()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
