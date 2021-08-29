using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAmbientPaletteEntry : RedBaseClass
	{
		private CName _brushCategory;

		[Ordinal(0)] 
		[RED("brushCategory")] 
		public CName BrushCategory
		{
			get => GetProperty(ref _brushCategory);
			set => SetProperty(ref _brushCategory, value);
		}
	}
}
