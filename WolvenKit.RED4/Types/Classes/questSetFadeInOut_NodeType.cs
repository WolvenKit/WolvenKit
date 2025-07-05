using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetFadeInOut_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)] 
		[RED("fadeColor")] 
		public CColor FadeColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("fadeIn")] 
		public CBool FadeIn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questSetFadeInOut_NodeType()
		{
			FadeColor = new CColor();
			FadeIn = true;
			Duration = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
