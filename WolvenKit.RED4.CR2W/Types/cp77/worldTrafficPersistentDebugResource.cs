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
			get => GetProperty(ref _brokenUIDs);
			set => SetProperty(ref _brokenUIDs, value);
		}

		[Ordinal(2)] 
		[RED("brokenUIDsDeadEnds")] 
		public CArray<worldTrafficLaneUID> BrokenUIDsDeadEnds
		{
			get => GetProperty(ref _brokenUIDsDeadEnds);
			set => SetProperty(ref _brokenUIDsDeadEnds, value);
		}

		public worldTrafficPersistentDebugResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
