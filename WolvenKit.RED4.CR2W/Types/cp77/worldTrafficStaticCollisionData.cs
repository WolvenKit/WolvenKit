using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficStaticCollisionData : ISerializable
	{
		private CArray<worldStaticLaneCollisions> _laneCollisions;

		[Ordinal(0)] 
		[RED("laneCollisions")] 
		public CArray<worldStaticLaneCollisions> LaneCollisions
		{
			get
			{
				if (_laneCollisions == null)
				{
					_laneCollisions = (CArray<worldStaticLaneCollisions>) CR2WTypeManager.Create("array:worldStaticLaneCollisions", "laneCollisions", cr2w, this);
				}
				return _laneCollisions;
			}
			set
			{
				if (_laneCollisions == value)
				{
					return;
				}
				_laneCollisions = value;
				PropertySet(this);
			}
		}

		public worldTrafficStaticCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
