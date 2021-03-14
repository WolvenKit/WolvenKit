using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaCollisionData : CVariable
	{
		private CUInt64 _areaID;
		private CArray<worldTrafficStaticCollisionSphere> _collisions;

		[Ordinal(0)] 
		[RED("areaID")] 
		public CUInt64 AreaID
		{
			get
			{
				if (_areaID == null)
				{
					_areaID = (CUInt64) CR2WTypeManager.Create("Uint64", "areaID", cr2w, this);
				}
				return _areaID;
			}
			set
			{
				if (_areaID == value)
				{
					return;
				}
				_areaID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("collisions")] 
		public CArray<worldTrafficStaticCollisionSphere> Collisions
		{
			get
			{
				if (_collisions == null)
				{
					_collisions = (CArray<worldTrafficStaticCollisionSphere>) CR2WTypeManager.Create("array:worldTrafficStaticCollisionSphere", "collisions", cr2w, this);
				}
				return _collisions;
			}
			set
			{
				if (_collisions == value)
				{
					return;
				}
				_collisions = value;
				PropertySet(this);
			}
		}

		public worldCrowdNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
