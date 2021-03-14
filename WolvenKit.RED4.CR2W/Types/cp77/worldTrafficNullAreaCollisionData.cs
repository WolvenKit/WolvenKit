using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionData : ISerializable
	{
		private worldCrowdNullAreaCollisionHeader _header;
		private CArray<worldCrowdNullAreaCollisionData> _nullAreaCollisions;

		[Ordinal(0)] 
		[RED("header")] 
		public worldCrowdNullAreaCollisionHeader Header
		{
			get
			{
				if (_header == null)
				{
					_header = (worldCrowdNullAreaCollisionHeader) CR2WTypeManager.Create("worldCrowdNullAreaCollisionHeader", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nullAreaCollisions")] 
		public CArray<worldCrowdNullAreaCollisionData> NullAreaCollisions
		{
			get
			{
				if (_nullAreaCollisions == null)
				{
					_nullAreaCollisions = (CArray<worldCrowdNullAreaCollisionData>) CR2WTypeManager.Create("array:worldCrowdNullAreaCollisionData", "nullAreaCollisions", cr2w, this);
				}
				return _nullAreaCollisions;
			}
			set
			{
				if (_nullAreaCollisions == value)
				{
					return;
				}
				_nullAreaCollisions = value;
				PropertySet(this);
			}
		}

		public worldTrafficNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
