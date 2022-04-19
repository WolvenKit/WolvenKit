using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PaperdollGlitchController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("PaperdollGlichRoot")] 
		public inkWidgetReference PaperdollGlichRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("GlitchAnimationName")] 
		public CName GlitchAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PaperdollGlitchController()
		{
			PaperdollGlichRoot = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
