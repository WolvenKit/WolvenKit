using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkShapePresetWraper : ISerializable
	{
		[Ordinal(0)] 
		[RED("shapePreset")] 
		public inkShapePreset ShapePreset
		{
			get => GetPropertyValue<inkShapePreset>();
			set => SetPropertyValue<inkShapePreset>(value);
		}

		public inkShapePresetWraper()
		{
			ShapePreset = new() { Points = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
