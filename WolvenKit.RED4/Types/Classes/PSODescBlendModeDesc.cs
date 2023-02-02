using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSODescBlendModeDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numTargets")] 
		public CUInt8 NumTargets
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(1)] 
		[RED("independent")] 
		public CBool Independent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("alphaToCoverage")] 
		public CBool AlphaToCoverage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("renderTarget", 8)] 
		public CArrayFixedSize<PSODescRenderTarget> RenderTarget
		{
			get => GetPropertyValue<CArrayFixedSize<PSODescRenderTarget>>();
			set => SetPropertyValue<CArrayFixedSize<PSODescRenderTarget>>(value);
		}

		public PSODescBlendModeDesc()
		{
			NumTargets = 1;
			RenderTarget = new(8);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
