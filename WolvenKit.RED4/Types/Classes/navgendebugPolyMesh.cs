using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugPolyMesh : ISerializable
	{
		[Ordinal(0)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(1)] 
		[RED("polygons")] 
		public CArray<navgendebugCompactPolygon> Polygons
		{
			get => GetPropertyValue<CArray<navgendebugCompactPolygon>>();
			set => SetPropertyValue<CArray<navgendebugCompactPolygon>>(value);
		}

		[Ordinal(2)] 
		[RED("bounds")] 
		public Box Bounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(3)] 
		[RED("cellSize")] 
		public CFloat CellSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("cellHeight")] 
		public CFloat CellHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("borderSize")] 
		public CInt32 BorderSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("maxEdgeError")] 
		public CFloat MaxEdgeError
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("maxVerticesPerPolygon")] 
		public CInt32 MaxVerticesPerPolygon
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public navgendebugPolyMesh()
		{
			Vertices = new();
			Polygons = new();
			Bounds = new Box { Min = new Vector4(), Max = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
