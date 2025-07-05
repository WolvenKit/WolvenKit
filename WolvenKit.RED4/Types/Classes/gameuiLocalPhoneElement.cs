using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiLocalPhoneElement : gameuiPhoneElementVisibility
	{
		[Ordinal(3)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("request")] 
		public CWeakHandle<inkAsyncSpawnRequest> Request
		{
			get => GetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>();
			set => SetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>(value);
		}

		[Ordinal(5)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public gameuiLocalPhoneElement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
