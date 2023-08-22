using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficPersistentResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public worldTrafficPersistentData Data
		{
			get => GetPropertyValue<worldTrafficPersistentData>();
			set => SetPropertyValue<worldTrafficPersistentData>(value);
		}

		public worldTrafficPersistentResource()
		{
			Data = new worldTrafficPersistentData { Lanes = new(), NeighborGroups = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
