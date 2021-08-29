using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationNode : worldNode
	{
		private CResourceAsyncReference<worldNavigationTileResource> _navigationTileResource;

		[Ordinal(4)] 
		[RED("navigationTileResource")] 
		public CResourceAsyncReference<worldNavigationTileResource> NavigationTileResource
		{
			get => GetProperty(ref _navigationTileResource);
			set => SetProperty(ref _navigationTileResource, value);
		}
	}
}
