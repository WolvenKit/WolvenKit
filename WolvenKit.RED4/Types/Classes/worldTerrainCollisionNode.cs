using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTerrainCollisionNode : worldNode
	{
		[Ordinal(4)] 
		[RED("materials")] 
		public CArray<CName> Materials
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("materialIndices")] 
		public CArray<CUInt8> MaterialIndices
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(6)] 
		[RED("heightfieldGeometry")] 
		public SerializationDeferredDataBuffer HeightfieldGeometry
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(7)] 
		[RED("actorTransform")] 
		public WorldTransform ActorTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(8)] 
		[RED("extents")] 
		public Vector4 Extents
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(9)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("rowScale")] 
		public CFloat RowScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("columnScale")] 
		public CFloat ColumnScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("heightScale")] 
		public CFloat HeightScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("increaseStreamingDistance")] 
		public CBool IncreaseStreamingDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldTerrainCollisionNode()
		{
			Materials = new();
			MaterialIndices = new();
			ActorTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			Extents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
