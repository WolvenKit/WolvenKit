using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkShapeCollectionResource : CResource
	{
		[Ordinal(1)] 
		[RED("presets")] 
		public CArray<inkShapePreset> Presets
		{
			get => GetPropertyValue<CArray<inkShapePreset>>();
			set => SetPropertyValue<CArray<inkShapePreset>>(value);
		}

		public inkShapeCollectionResource()
		{
			Presets = new();
		}
	}
}
