using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsSectorCacheArtifact : CResource
	{
		private Box _sectorBounds;
		private CArray<physicsGeometryKey> _sectorGeometries;

		[Ordinal(1)] 
		[RED("sectorBounds")] 
		public Box SectorBounds
		{
			get => GetProperty(ref _sectorBounds);
			set => SetProperty(ref _sectorBounds, value);
		}

		[Ordinal(2)] 
		[RED("sectorGeometries")] 
		public CArray<physicsGeometryKey> SectorGeometries
		{
			get => GetProperty(ref _sectorGeometries);
			set => SetProperty(ref _sectorGeometries, value);
		}
	}
}
