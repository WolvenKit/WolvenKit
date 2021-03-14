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
			get
			{
				if (_sectorBounds == null)
				{
					_sectorBounds = (Box) CR2WTypeManager.Create("Box", "sectorBounds", cr2w, this);
				}
				return _sectorBounds;
			}
			set
			{
				if (_sectorBounds == value)
				{
					return;
				}
				_sectorBounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sectorGeometries")] 
		public CArray<physicsGeometryKey> SectorGeometries
		{
			get
			{
				if (_sectorGeometries == null)
				{
					_sectorGeometries = (CArray<physicsGeometryKey>) CR2WTypeManager.Create("array:physicsGeometryKey", "sectorGeometries", cr2w, this);
				}
				return _sectorGeometries;
			}
			set
			{
				if (_sectorGeometries == value)
				{
					return;
				}
				_sectorGeometries = value;
				PropertySet(this);
			}
		}

		public physicsSectorCacheArtifact(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
