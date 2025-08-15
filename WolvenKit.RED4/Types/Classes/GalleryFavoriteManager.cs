using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryFavoriteManager : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("favoritesSettingGroup")] 
		public CName FavoritesSettingGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("favoritesSettingVar")] 
		public CName FavoritesSettingVar
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(4)] 
		[RED("favoritesValue")] 
		public CArray<CUInt32> FavoritesValue
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public GalleryFavoriteManager()
		{
			FavoritesValue = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
