using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamUICollisionData : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("uvs")] 
		public CArray<Vector2> Uvs
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}

		[Ordinal(1)] 
		[RED("trianglesIndices")] 
		public CArray<CUInt16> TrianglesIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(2)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		public meshMeshParamUICollisionData()
		{
			Uvs = new();
			TrianglesIndices = new();
			Vertices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
