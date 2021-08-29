using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAmbientPaletteExclusionAreaNode : worldAreaShapeNode
	{
		private CArray<audioAmbientPaletteEntry> _exclusionPaletteEntries;

		[Ordinal(6)] 
		[RED("exclusionPaletteEntries")] 
		public CArray<audioAmbientPaletteEntry> ExclusionPaletteEntries
		{
			get => GetProperty(ref _exclusionPaletteEntries);
			set => SetProperty(ref _exclusionPaletteEntries, value);
		}
	}
}
