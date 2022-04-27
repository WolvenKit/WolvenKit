using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficPersistentNode : worldNode
	{
		[Ordinal(4)] 
		[RED("resource")] 
		public CResourceAsyncReference<worldTrafficPersistentResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<worldTrafficPersistentResource>>();
			set => SetPropertyValue<CResourceAsyncReference<worldTrafficPersistentResource>>(value);
		}

		public worldTrafficPersistentNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
