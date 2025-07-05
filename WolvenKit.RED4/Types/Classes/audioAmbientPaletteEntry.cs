using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientPaletteEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("brushCategory")] 
		public CName BrushCategory
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioAmbientPaletteEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
