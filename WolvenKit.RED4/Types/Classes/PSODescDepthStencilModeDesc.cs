using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSODescDepthStencilModeDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("depthTestEnable")] 
		public CBool DepthTestEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("depthWriteEnable")] 
		public CBool DepthWriteEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("depthFunc")] 
		public CEnum<PSODescDepthStencilModeComparisonMode> DepthFunc
		{
			get => GetPropertyValue<CEnum<PSODescDepthStencilModeComparisonMode>>();
			set => SetPropertyValue<CEnum<PSODescDepthStencilModeComparisonMode>>(value);
		}

		[Ordinal(3)] 
		[RED("stencilEnable")] 
		public CBool StencilEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("stencilReadMask")] 
		public CBool StencilReadMask
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("stencilWriteMask")] 
		public CBool StencilWriteMask
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("frontFace")] 
		public PSODescStencilFuncDesc FrontFace
		{
			get => GetPropertyValue<PSODescStencilFuncDesc>();
			set => SetPropertyValue<PSODescStencilFuncDesc>(value);
		}

		public PSODescDepthStencilModeDesc()
		{
			FrontFace = new PSODescStencilFuncDesc();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
