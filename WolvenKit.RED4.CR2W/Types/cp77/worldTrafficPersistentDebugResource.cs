using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentDebugResource : resStreamedResource
	{
		private CArray<worldTrafficLaneUID> _brokenUIDs;
		private CArray<worldTrafficLaneUID> _brokenUIDsDeadEnds;

		[Ordinal(1)] 
		[RED("brokenUIDs")] 
		public CArray<worldTrafficLaneUID> BrokenUIDs
		{
			get
			{
				if (_brokenUIDs == null)
				{
					_brokenUIDs = (CArray<worldTrafficLaneUID>) CR2WTypeManager.Create("array:worldTrafficLaneUID", "brokenUIDs", cr2w, this);
				}
				return _brokenUIDs;
			}
			set
			{
				if (_brokenUIDs == value)
				{
					return;
				}
				_brokenUIDs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("brokenUIDsDeadEnds")] 
		public CArray<worldTrafficLaneUID> BrokenUIDsDeadEnds
		{
			get
			{
				if (_brokenUIDsDeadEnds == null)
				{
					_brokenUIDsDeadEnds = (CArray<worldTrafficLaneUID>) CR2WTypeManager.Create("array:worldTrafficLaneUID", "brokenUIDsDeadEnds", cr2w, this);
				}
				return _brokenUIDsDeadEnds;
			}
			set
			{
				if (_brokenUIDsDeadEnds == value)
				{
					return;
				}
				_brokenUIDsDeadEnds = value;
				PropertySet(this);
			}
		}

		public worldTrafficPersistentDebugResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
