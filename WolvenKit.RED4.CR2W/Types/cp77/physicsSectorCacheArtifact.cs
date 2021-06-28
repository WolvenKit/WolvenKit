using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSectorCacheArtifact : CResource
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

		public physicsSectorCacheArtifact(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
