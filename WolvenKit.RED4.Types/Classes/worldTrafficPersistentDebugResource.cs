using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficPersistentDebugResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("brokenUIDs")] 
		public CArray<worldTrafficLaneUID> BrokenUIDs
		{
			get => GetPropertyValue<CArray<worldTrafficLaneUID>>();
			set => SetPropertyValue<CArray<worldTrafficLaneUID>>(value);
		}

		[Ordinal(2)] 
		[RED("brokenUIDsDeadEnds")] 
		public CArray<worldTrafficLaneUID> BrokenUIDsDeadEnds
		{
			get => GetPropertyValue<CArray<worldTrafficLaneUID>>();
			set => SetPropertyValue<CArray<worldTrafficLaneUID>>(value);
		}

		public worldTrafficPersistentDebugResource()
		{
			BrokenUIDs = new();
			BrokenUIDsDeadEnds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
