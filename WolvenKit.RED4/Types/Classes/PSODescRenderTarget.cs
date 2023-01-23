using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSODescRenderTarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blendEnable")] 
		public CBool BlendEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("writeMask")] 
		public CEnum<PSODescBlendModeWriteMask> WriteMask
		{
			get => GetPropertyValue<CEnum<PSODescBlendModeWriteMask>>();
			set => SetPropertyValue<CEnum<PSODescBlendModeWriteMask>>(value);
		}

		[Ordinal(2)] 
		[RED("colorOp")] 
		public CEnum<PSODescBlendModeOp> ColorOp
		{
			get => GetPropertyValue<CEnum<PSODescBlendModeOp>>();
			set => SetPropertyValue<CEnum<PSODescBlendModeOp>>(value);
		}

		[Ordinal(3)] 
		[RED("alphaOp")] 
		public CEnum<PSODescBlendModeOp> AlphaOp
		{
			get => GetPropertyValue<CEnum<PSODescBlendModeOp>>();
			set => SetPropertyValue<CEnum<PSODescBlendModeOp>>(value);
		}

		[Ordinal(4)] 
		[RED("destFactor")] 
		public CEnum<PSODescBlendModeFactor> DestFactor
		{
			get => GetPropertyValue<CEnum<PSODescBlendModeFactor>>();
			set => SetPropertyValue<CEnum<PSODescBlendModeFactor>>(value);
		}

		[Ordinal(5)] 
		[RED("destAlphaFactor")] 
		public CEnum<PSODescBlendModeFactor> DestAlphaFactor
		{
			get => GetPropertyValue<CEnum<PSODescBlendModeFactor>>();
			set => SetPropertyValue<CEnum<PSODescBlendModeFactor>>(value);
		}

		[Ordinal(6)] 
		[RED("srcFactor")] 
		public CEnum<PSODescBlendModeFactor> SrcFactor
		{
			get => GetPropertyValue<CEnum<PSODescBlendModeFactor>>();
			set => SetPropertyValue<CEnum<PSODescBlendModeFactor>>(value);
		}

		[Ordinal(7)] 
		[RED("srcAlphaFactor")] 
		public CEnum<PSODescBlendModeFactor> SrcAlphaFactor
		{
			get => GetPropertyValue<CEnum<PSODescBlendModeFactor>>();
			set => SetPropertyValue<CEnum<PSODescBlendModeFactor>>(value);
		}

		public PSODescRenderTarget()
		{
			WriteMask = Enums.PSODescBlendModeWriteMask.MASK_RGBA;
			DestFactor = Enums.PSODescBlendModeFactor.FAC_One;
			DestAlphaFactor = Enums.PSODescBlendModeFactor.FAC_One;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
