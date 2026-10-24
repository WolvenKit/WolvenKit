using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAmbientPaletteExclusionAreaNode : worldAreaShapeNode
	{
		[Ordinal(4)] 
		[RED("exclusionPaletteEntries")] 
		public CArray<audioAmbientPaletteEntry> ExclusionPaletteEntries
		{
			get => GetPropertyValue<CArray<audioAmbientPaletteEntry>>();
			set => SetPropertyValue<CArray<audioAmbientPaletteEntry>>(value);
		}

		public worldAmbientPaletteExclusionAreaNode()
		{
			Color = new CColor { Red = 255, Green = 127, Blue = 127, Alpha = 255 };
			ExclusionPaletteEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
