using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCollisionNode : worldNode
	{
		[Ordinal(4)] 
		[RED("compiledData")] 
		public DataBuffer CompiledData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(5)] 
		[RED("numActors")] 
		public CUInt16 NumActors
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(6)] 
		[RED("numShapeInfos")] 
		public CUInt16 NumShapeInfos
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(7)] 
		[RED("numShapePositions")] 
		public CUInt16 NumShapePositions
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(8)] 
		[RED("numShapeRotations")] 
		public CUInt16 NumShapeRotations
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(9)] 
		[RED("numScales")] 
		public CUInt16 NumScales
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(10)] 
		[RED("numMaterials")] 
		public CUInt16 NumMaterials
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(11)] 
		[RED("numPresets")] 
		public CUInt16 NumPresets
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(12)] 
		[RED("numMaterialIndices")] 
		public CUInt16 NumMaterialIndices
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(13)] 
		[RED("numShapeIndices")] 
		public CUInt16 NumShapeIndices
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(14)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(15)] 
		[RED("extents")] 
		public Vector4 Extents
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(16)] 
		[RED("lod")] 
		public CUInt8 Lod
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(17)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldCollisionNode()
		{
			Extents = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
