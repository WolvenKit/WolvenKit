using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChromaticAberrationAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("chromaticAberrationEnabled")] 
		public CBool ChromaticAberrationEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("chromaticAberrationMargin")] 
		public CFloat ChromaticAberrationMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("chromaticAberrationSize")] 
		public Vector2 ChromaticAberrationSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(5)] 
		[RED("chromaticAberrationExp")] 
		public CFloat ChromaticAberrationExp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("subpixelDispersal")] 
		public CFloat SubpixelDispersal
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ChromaticAberrationAreaSettings()
		{
			Enable = true;
			ChromaticAberrationSize = new Vector2 { X = 1.400000F, Y = 1.400000F };
			ChromaticAberrationExp = 0.800000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
