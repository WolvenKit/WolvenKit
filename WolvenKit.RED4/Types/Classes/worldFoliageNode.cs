using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageNode : worldNode
	{
		[Ordinal(2)] 
		[RED("mesh")] 
		public CResourceAsyncReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(3)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("foliageResource")] 
		public CResourceAsyncReference<worldFoliageCompiledResource> FoliageResource
		{
			get => GetPropertyValue<CResourceAsyncReference<worldFoliageCompiledResource>>();
			set => SetPropertyValue<CResourceAsyncReference<worldFoliageCompiledResource>>(value);
		}

		[Ordinal(5)] 
		[RED("foliageLocalBounds")] 
		public Box FoliageLocalBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(6)] 
		[RED("autoHideDistanceScale")] 
		public CFloat AutoHideDistanceScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("lodDistanceScale")] 
		public CFloat LodDistanceScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("populationSpanInfo")] 
		public worldFoliagePopulationSpanInfo PopulationSpanInfo
		{
			get => GetPropertyValue<worldFoliagePopulationSpanInfo>();
			set => SetPropertyValue<worldFoliagePopulationSpanInfo>(value);
		}

		[Ordinal(10)] 
		[RED("destructionHash")] 
		public CUInt64 DestructionHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(11)] 
		[RED("meshHeight")] 
		public CFloat MeshHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldFoliageNode()
		{
			FoliageLocalBounds = new Box();
			AutoHideDistanceScale = 1.000000F;
			LodDistanceScale = 1.000000F;
			StreamingDistance = -1.000000F;
			PopulationSpanInfo = new worldFoliagePopulationSpanInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
