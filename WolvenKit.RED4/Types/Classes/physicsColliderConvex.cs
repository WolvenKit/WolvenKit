using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsColliderConvex : physicsICollider
	{
		[Ordinal(8)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(9)] 
		[RED("indexBuffer")] 
		public CArray<CUInt8> IndexBuffer
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(10)] 
		[RED("polygonVertices")] 
		public CArray<CUInt16> PolygonVertices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(11)] 
		[RED("compiledGeometryBuffer")] 
		public DataBuffer CompiledGeometryBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public physicsColliderConvex()
		{
			LocalToBody = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			MaterialApperanceOverrides = new();
			VolumeModifier = 1.000000F;
			Vertices = new();
			IndexBuffer = new();
			PolygonVertices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
