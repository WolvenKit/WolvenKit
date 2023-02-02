using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSODescRasterizerModeDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("wireframe")] 
		public CBool Wireframe
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("frontWinding")] 
		public CEnum<PSODescRasterizerModeFrontFaceWinding> FrontWinding
		{
			get => GetPropertyValue<CEnum<PSODescRasterizerModeFrontFaceWinding>>();
			set => SetPropertyValue<CEnum<PSODescRasterizerModeFrontFaceWinding>>(value);
		}

		[Ordinal(2)] 
		[RED("cullMode")] 
		public CEnum<PSODescRasterizerModeCullMode> CullMode
		{
			get => GetPropertyValue<CEnum<PSODescRasterizerModeCullMode>>();
			set => SetPropertyValue<CEnum<PSODescRasterizerModeCullMode>>(value);
		}

		[Ordinal(3)] 
		[RED("allowMSAA")] 
		public CBool AllowMSAA
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("conservativeRasterization")] 
		public CBool ConservativeRasterization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("offsetMode")] 
		public CEnum<PSODescRasterizerModeOffsetMode> OffsetMode
		{
			get => GetPropertyValue<CEnum<PSODescRasterizerModeOffsetMode>>();
			set => SetPropertyValue<CEnum<PSODescRasterizerModeOffsetMode>>(value);
		}

		[Ordinal(6)] 
		[RED("scissors")] 
		public CBool Scissors
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PSODescRasterizerModeDesc()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
