using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GeometryShape : ISerializable
	{
		[Ordinal(0)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<CUInt16> Indices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(2)] 
		[RED("faces")] 
		public CArray<GeometryShapeFace> Faces
		{
			get => GetPropertyValue<CArray<GeometryShapeFace>>();
			set => SetPropertyValue<CArray<GeometryShapeFace>>(value);
		}

		public GeometryShape()
		{
			Vertices = new();
			Indices = new();
			Faces = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
