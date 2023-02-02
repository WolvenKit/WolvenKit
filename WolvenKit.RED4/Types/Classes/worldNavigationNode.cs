using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldNavigationNode : worldNode
	{
		[Ordinal(4)] 
		[RED("navigationTileResource")] 
		public CResourceAsyncReference<worldNavigationTileResource> NavigationTileResource
		{
			get => GetPropertyValue<CResourceAsyncReference<worldNavigationTileResource>>();
			set => SetPropertyValue<CResourceAsyncReference<worldNavigationTileResource>>(value);
		}

		public worldNavigationNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
