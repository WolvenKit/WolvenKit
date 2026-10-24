using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HiddenModManagerPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(8)] 
		[RED("listOfHiddenMods")] 
		public CArray<inkModioModInfos> ListOfHiddenMods
		{
			get => GetPropertyValue<CArray<inkModioModInfos>>();
			set => SetPropertyValue<CArray<inkModioModInfos>>(value);
		}

		[Ordinal(9)] 
		[RED("listOfModLogoPath")] 
		public CArray<CString> ListOfModLogoPath
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(10)] 
		[RED("listOfHiddenAuthors")] 
		public CArray<inkModAuthorInfo> ListOfHiddenAuthors
		{
			get => GetPropertyValue<CArray<inkModAuthorInfo>>();
			set => SetPropertyValue<CArray<inkModAuthorInfo>>(value);
		}

		public HiddenModManagerPopupData()
		{
			ListOfHiddenMods = new();
			ListOfModLogoPath = new();
			ListOfHiddenAuthors = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
