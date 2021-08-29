using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GeometryShape : ISerializable
	{
		private CArray<Vector3> _vertices;
		private CArray<CUInt16> _indices;
		private CArray<GeometryShapeFace> _faces;

		[Ordinal(0)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetProperty(ref _vertices);
			set => SetProperty(ref _vertices, value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<CUInt16> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		[Ordinal(2)] 
		[RED("faces")] 
		public CArray<GeometryShapeFace> Faces
		{
			get => GetProperty(ref _faces);
			set => SetProperty(ref _faces, value);
		}
	}
}
