using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldGeometryShapeNode : worldNode
	{
		private CColor _color;
		private CHandle<GeometryShape> _shape;

		[Ordinal(4)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(5)] 
		[RED("shape")] 
		public CHandle<GeometryShape> Shape
		{
			get => GetProperty(ref _shape);
			set => SetProperty(ref _shape, value);
		}
	}
}
