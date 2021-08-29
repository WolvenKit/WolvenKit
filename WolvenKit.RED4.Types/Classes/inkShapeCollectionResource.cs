using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkShapeCollectionResource : CResource
	{
		private CArray<inkShapePreset> _presets;

		[Ordinal(1)] 
		[RED("presets")] 
		public CArray<inkShapePreset> Presets
		{
			get => GetProperty(ref _presets);
			set => SetProperty(ref _presets, value);
		}
	}
}
