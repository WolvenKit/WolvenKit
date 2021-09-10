using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAmbientPaletteExclusionAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("exclusionPaletteEntries")] 
		public CArray<audioAmbientPaletteEntry> ExclusionPaletteEntries
		{
			get => GetPropertyValue<CArray<audioAmbientPaletteEntry>>();
			set => SetPropertyValue<CArray<audioAmbientPaletteEntry>>(value);
		}

		public worldAmbientPaletteExclusionAreaNode()
		{
			ExclusionPaletteEntries = new();
		}
	}
}
