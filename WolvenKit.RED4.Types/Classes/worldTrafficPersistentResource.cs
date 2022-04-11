using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Data = new() { Lanes = new(), NeighborGroups = new() };
		}
	}
}
