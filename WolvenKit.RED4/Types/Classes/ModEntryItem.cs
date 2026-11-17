using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModEntryItem : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("modTitle")] 
		public inkTextWidgetReference ModTitle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("modNumberOfDownloadsText")] 
		public inkTextWidgetReference ModNumberOfDownloadsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("modNumberOfDownloadsIcon")] 
		public inkImageWidgetReference ModNumberOfDownloadsIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("modNumberOfLikesText")] 
		public inkTextWidgetReference ModNumberOfLikesText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("modNumberOfLikesIcon")] 
		public inkImageWidgetReference ModNumberOfLikesIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("modSizeText")] 
		public inkTextWidgetReference ModSizeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("modSizeIcon")] 
		public inkImageWidgetReference ModSizeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("entryOutlineImage")] 
		public inkImageWidgetReference EntryOutlineImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("hoverHighlightCanvas")] 
		public inkWidgetReference HoverHighlightCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("backgroundColorImage")] 
		public inkImageWidgetReference BackgroundColorImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("downloadText")] 
		public inkTextWidgetReference DownloadText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("downloadBarFillIcon")] 
		public inkWidgetReference DownloadBarFillIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("downloadBarOutlineIcon")] 
		public inkWidgetReference DownloadBarOutlineIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("likedByUserIcon")] 
		public inkWidgetReference LikedByUserIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("newModWidget")] 
		public inkWidgetReference NewModWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("modLogoWidget")] 
		public inkImageWidgetReference ModLogoWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("subscribedToModIcon")] 
		public inkImageWidgetReference SubscribedToModIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("logoLoadingWidget")] 
		public inkWidgetReference LogoLoadingWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("logoLoadingSpinner")] 
		public inkWidgetReference LogoLoadingSpinner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("logoLoading_bg")] 
		public inkImageWidgetReference LogoLoading_bg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("logoErrorWidget")] 
		public inkImageWidgetReference LogoErrorWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("waitingForDataWidget")] 
		public inkWidgetReference WaitingForDataWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("waitingForDataLoadingSpinner")] 
		public inkWidgetReference WaitingForDataLoadingSpinner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("emptyDataWidget")] 
		public inkWidgetReference EmptyDataWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(57)] 
		[RED("warningErrorWidget")] 
		public inkWidgetReference WarningErrorWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("downloadProgressBar")] 
		public inkCompoundWidgetReference DownloadProgressBar
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(59)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(60)] 
		[RED("basePreviewSize")] 
		public Vector2 BasePreviewSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(61)] 
		[RED("ID")] 
		public CInt32 ID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(62)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		[Ordinal(63)] 
		[RED("isUserSubscribedToMod")] 
		public CBool IsUserSubscribedToMod
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("isModEntrySelected")] 
		public CBool IsModEntrySelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("numberOfScreenshotRequests")] 
		public CInt32 NumberOfScreenshotRequests
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(66)] 
		[RED("isWaitingForData")] 
		public CBool IsWaitingForData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("isInWarningDataState")] 
		public CBool IsInWarningDataState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("hasNoData")] 
		public CBool HasNoData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(69)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(70)] 
		[RED("modID")] 
		public CInt64 ModID
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		public ModEntryItem()
		{
			ModTitle = new inkTextWidgetReference();
			ModNumberOfDownloadsText = new inkTextWidgetReference();
			ModNumberOfDownloadsIcon = new inkImageWidgetReference();
			ModNumberOfLikesText = new inkTextWidgetReference();
			ModNumberOfLikesIcon = new inkImageWidgetReference();
			ModSizeText = new inkTextWidgetReference();
			ModSizeIcon = new inkImageWidgetReference();
			EntryOutlineImage = new inkImageWidgetReference();
			HoverHighlightCanvas = new inkWidgetReference();
			BackgroundColorImage = new inkImageWidgetReference();
			DownloadText = new inkTextWidgetReference();
			DownloadBarFillIcon = new inkWidgetReference();
			DownloadBarOutlineIcon = new inkWidgetReference();
			LikedByUserIcon = new inkWidgetReference();
			NewModWidget = new inkWidgetReference();
			ModLogoWidget = new inkImageWidgetReference();
			SubscribedToModIcon = new inkImageWidgetReference();
			LogoLoadingWidget = new inkWidgetReference();
			LogoLoadingSpinner = new inkWidgetReference();
			LogoLoading_bg = new inkImageWidgetReference();
			LogoErrorWidget = new inkImageWidgetReference();
			WaitingForDataWidget = new inkWidgetReference();
			WaitingForDataLoadingSpinner = new inkWidgetReference();
			EmptyDataWidget = new inkWidgetReference();
			WarningErrorWidget = new inkWidgetReference();
			DownloadProgressBar = new inkCompoundWidgetReference();
			BasePreviewSize = new Vector2();
			ColorNames = new ModsMenuColorsNames();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
