using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsSectorCacheArtifact : CResource
	{
		[Ordinal(1)] 
		[RED("sectorBounds")] 
		public Box SectorBounds
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(2)] 
		[RED("sectorGeometries")] 
		public CArray<physicsGeometryKey> SectorGeometries
		{
			get => GetPropertyValue<CArray<physicsGeometryKey>>();
			set => SetPropertyValue<CArray<physicsGeometryKey>>(value);
		}

		public physicsSectorCacheArtifact()
		{
			SectorBounds = new Box { Min = new Vector4(), Max = new Vector4() };
			SectorGeometries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
