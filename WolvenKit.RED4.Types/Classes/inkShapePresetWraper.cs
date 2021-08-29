using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkShapePresetWraper : ISerializable
	{
		private inkShapePreset _shapePreset;

		[Ordinal(0)] 
		[RED("shapePreset")] 
		public inkShapePreset ShapePreset
		{
			get => GetProperty(ref _shapePreset);
			set => SetProperty(ref _shapePreset, value);
		}
	}
}
