using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugInputGeometry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("triangles")] 
		public CArray<navgendebugInputGeometryTriangle> Triangles
		{
			get => GetPropertyValue<CArray<navgendebugInputGeometryTriangle>>();
			set => SetPropertyValue<CArray<navgendebugInputGeometryTriangle>>(value);
		}

		[Ordinal(1)] 
		[RED("tileBoundingBox")] 
		public Box TileBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(2)] 
		[RED("extrudedBoundingBox")] 
		public Box ExtrudedBoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		public navgendebugInputGeometry()
		{
			Triangles = new();
			TileBoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };
			ExtrudedBoundingBox = new Box { Min = new Vector4(), Max = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
