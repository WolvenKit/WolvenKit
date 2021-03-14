using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticLaneCollisions : CVariable
	{
		private worldTrafficLaneUID _lane;
		private CArray<worldTrafficStaticCollisionSphere> _collisions;
		private CFloat _deadEndStart;

		[Ordinal(0)] 
		[RED("lane")] 
		public worldTrafficLaneUID Lane
		{
			get
			{
				if (_lane == null)
				{
					_lane = (worldTrafficLaneUID) CR2WTypeManager.Create("worldTrafficLaneUID", "lane", cr2w, this);
				}
				return _lane;
			}
			set
			{
				if (_lane == value)
				{
					return;
				}
				_lane = value;
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

		[Ordinal(2)] 
		[RED("deadEndStart")] 
		public CFloat DeadEndStart
		{
			get
			{
				if (_deadEndStart == null)
				{
					_deadEndStart = (CFloat) CR2WTypeManager.Create("Float", "deadEndStart", cr2w, this);
				}
				return _deadEndStart;
			}
			set
			{
				if (_deadEndStart == value)
				{
					return;
				}
				_deadEndStart = value;
				PropertySet(this);
			}
		}

		public worldStaticLaneCollisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
