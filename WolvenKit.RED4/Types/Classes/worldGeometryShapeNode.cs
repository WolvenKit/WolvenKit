using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGeometryShapeNode : worldNode
	{
		[Ordinal(4)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(5)] 
		[RED("shape")] 
		public CHandle<GeometryShape> Shape
		{
			get => GetPropertyValue<CHandle<GeometryShape>>();
			set => SetPropertyValue<CHandle<GeometryShape>>(value);
		}

		public worldGeometryShapeNode()
		{
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
