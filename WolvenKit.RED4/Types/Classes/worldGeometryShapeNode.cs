using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGeometryShapeNode : worldNode
	{
		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(3)] 
		[RED("shape")] 
		public CHandle<GeometryShape> Shape
		{
			get => GetPropertyValue<CHandle<GeometryShape>>();
			set => SetPropertyValue<CHandle<GeometryShape>>(value);
		}

		public worldGeometryShapeNode()
		{
			Color = new CColor { Red = 128, Green = 128, Blue = 96, Alpha = 128 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
