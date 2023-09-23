using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsSectorCacheArtifact : CResource
	{
		[Ordinal(1)] 
		[RED("sectorGeometryKeys")] 
		public CArray<physicsGeometryKey> SectorGeometryKeys
		{
			get => GetPropertyValue<CArray<physicsGeometryKey>>();
			set => SetPropertyValue<CArray<physicsGeometryKey>>(value);
		}

		[Ordinal(2)] 
		[RED("sectorInPlaceGeometry")] 
		public CHandle<physicsGeometryCacheArtifact> SectorInPlaceGeometry
		{
			get => GetPropertyValue<CHandle<physicsGeometryCacheArtifact>>();
			set => SetPropertyValue<CHandle<physicsGeometryCacheArtifact>>(value);
		}

		[Ordinal(3)] 
		[RED("sectorBounds")] 
		public Box SectorBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		public physicsSectorCacheArtifact()
		{
			SectorGeometryKeys = new();
			SectorBounds = new Box { Min = new Vector4(), Max = new Vector4() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
