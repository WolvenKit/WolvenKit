using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModDetailsItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("modName")] 
		public inkTextWidgetReference ModName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("modioIcon")] 
		public inkImageWidgetReference ModioIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("modAuthorName")] 
		public inkTextWidgetReference ModAuthorName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("modAuthorLinkedAccountName")] 
		public inkTextWidgetReference ModAuthorLinkedAccountName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("modioText")] 
		public inkTextWidgetReference ModioText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("platformText")] 
		public inkTextWidgetReference PlatformText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("modPlatformSeparator")] 
		public inkWidgetReference ModPlatformSeparator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("version")] 
		public inkTextWidgetReference Version
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("changelog")] 
		public inkTextWidgetReference Changelog
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("summary")] 
		public inkTextWidgetReference Summary
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("subscriptionButton")] 
		public inkWidgetReference SubscriptionButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("likeButton")] 
		public inkWidgetReference LikeButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("authorButton")] 
		public inkWidgetReference AuthorButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("numberOfLikesText")] 
		public inkTextWidgetReference NumberOfLikesText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("numberOfLikesIcon")] 
		public inkImageWidgetReference NumberOfLikesIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("modNumberOfDownloadsText")] 
		public inkTextWidgetReference ModNumberOfDownloadsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("modNumberOfDownloadsIcon")] 
		public inkImageWidgetReference ModNumberOfDownloadsIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("modSizeText")] 
		public inkTextWidgetReference ModSizeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("modSizeIcon")] 
		public inkImageWidgetReference ModSizeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("modTooBigIcon")] 
		public inkImageWidgetReference ModTooBigIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("lastUpdatedTimeText")] 
		public inkTextWidgetReference LastUpdatedTimeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("lastUpdatedTimeIcon")] 
		public inkImageWidgetReference LastUpdatedTimeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("downloadProgressBar")] 
		public inkCompoundWidgetReference DownloadProgressBar
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("emptyMainCarouselImage")] 
		public inkWidgetReference EmptyMainCarouselImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("emptyLeftCarouselImage")] 
		public inkWidgetReference EmptyLeftCarouselImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("emptyRightCarouselImage")] 
		public inkWidgetReference EmptyRightCarouselImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("mainCarouselImage")] 
		public inkImageWidgetReference MainCarouselImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("leftCarouselImage")] 
		public inkImageWidgetReference LeftCarouselImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("rightCarouselImage")] 
		public inkImageWidgetReference RightCarouselImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("mainCarouselLoadingPanel")] 
		public inkWidgetReference MainCarouselLoadingPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("leftCarouselLoadingPanel")] 
		public inkWidgetReference LeftCarouselLoadingPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("rightCarouselLoadingPanel")] 
		public inkWidgetReference RightCarouselLoadingPanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("loadingFailedPanelWidget")] 
		public inkWidgetReference LoadingFailedPanelWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("mainCarouselImageController")] 
		public inkWidgetReference MainCarouselImageController
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("leftCarouselArrow")] 
		public inkWidgetReference LeftCarouselArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("rightCarouselArrow")] 
		public inkWidgetReference RightCarouselArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("carouselText")] 
		public inkTextWidgetReference CarouselText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("carouselTextShadow")] 
		public inkTextWidgetReference CarouselTextShadow
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("moreOptionsDropdownListManagerRef")] 
		public inkWidgetReference MoreOptionsDropdownListManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("moreOptionsDropdownButtonManagerRef")] 
		public inkWidgetReference MoreOptionsDropdownButtonManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("emptyAnimationWidget")] 
		public inkWidgetReference EmptyAnimationWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("emptyPreviewCanvas")] 
		public inkWidgetReference EmptyPreviewCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("topEmptyPreviewImage")] 
		public inkWidgetReference TopEmptyPreviewImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(45)] 
		[RED("buttonEmptyPreviewImage")] 
		public inkWidgetReference ButtonEmptyPreviewImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("middleEmptyPreviewImage")] 
		public inkWidgetReference MiddleEmptyPreviewImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("lineEmptyPreviewImage")] 
		public inkWidgetReference LineEmptyPreviewImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("bottomEmptyPreviewImage")] 
		public inkWidgetReference BottomEmptyPreviewImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("infoTitleEmptyPreviewImage")] 
		public inkWidgetReference InfoTitleEmptyPreviewImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("infoDescEmptyPreviewImage")] 
		public inkWidgetReference InfoDescEmptyPreviewImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("modDetailsContent")] 
		public inkWidgetReference ModDetailsContent
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("tagsGridWidgetRef")] 
		public inkCompoundWidgetReference TagsGridWidgetRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("pendingActivationOrDeactivationText")] 
		public inkTextWidgetReference PendingActivationOrDeactivationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("scrollWidgetRef")] 
		public inkWidgetReference ScrollWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("enableDisableToggleWidget")] 
		public inkWidgetReference EnableDisableToggleWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("enableDisableToggleText")] 
		public inkTextWidgetReference EnableDisableToggleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(57)] 
		[RED("enableDisableToggleGradient")] 
		public inkWidgetReference EnableDisableToggleGradient
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("enableDisableToggleUpperLine")] 
		public inkWidgetReference EnableDisableToggleUpperLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(59)] 
		[RED("enableDisableToggleBottomLine")] 
		public inkWidgetReference EnableDisableToggleBottomLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(60)] 
		[RED("enableDisableToggleNavController")] 
		public CWeakHandle<inkDiscreteNavigationController> EnableDisableToggleNavController
		{
			get => GetPropertyValue<CWeakHandle<inkDiscreteNavigationController>>();
			set => SetPropertyValue<CWeakHandle<inkDiscreteNavigationController>>(value);
		}

		[Ordinal(61)] 
		[RED("moreOptionsDropdownListController")] 
		public CWeakHandle<MoreOptionsDropdownListController> MoreOptionsDropdownListController
		{
			get => GetPropertyValue<CWeakHandle<MoreOptionsDropdownListController>>();
			set => SetPropertyValue<CWeakHandle<MoreOptionsDropdownListController>>(value);
		}

		[Ordinal(62)] 
		[RED("moreOptionsDropdownButtonController")] 
		public CWeakHandle<MoreOptionsButtonController> MoreOptionsDropdownButtonController
		{
			get => GetPropertyValue<CWeakHandle<MoreOptionsButtonController>>();
			set => SetPropertyValue<CWeakHandle<MoreOptionsButtonController>>(value);
		}

		[Ordinal(63)] 
		[RED("currentCarouselIndex")] 
		public CInt64 CurrentCarouselIndex
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(64)] 
		[RED("carouselImagePaths")] 
		public CArray<CString> CarouselImagePaths
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(65)] 
		[RED("carouselSize")] 
		public CInt64 CarouselSize
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(66)] 
		[RED("colorNames")] 
		public ModsMenuColorsNames ColorNames
		{
			get => GetPropertyValue<ModsMenuColorsNames>();
			set => SetPropertyValue<ModsMenuColorsNames>(value);
		}

		[Ordinal(67)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		[Ordinal(68)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(69)] 
		[RED("isModTooBigToInstall")] 
		public CBool IsModTooBigToInstall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(70)] 
		[RED("tagsItemArray")] 
		public CArray<CWeakHandle<TagWidgetItem>> TagsItemArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<TagWidgetItem>>>();
			set => SetPropertyValue<CArray<CWeakHandle<TagWidgetItem>>>(value);
		}

		[Ordinal(71)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		[Ordinal(72)] 
		[RED("isModSubscribedByUser")] 
		public CBool IsModSubscribedByUser
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(73)] 
		[RED("enableDisableToggleAnimProxy")] 
		public CHandle<inkanimProxy> EnableDisableToggleAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(74)] 
		[RED("bIsModEnabled")] 
		public CBool BIsModEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("isToggleHovered")] 
		public CBool IsToggleHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(76)] 
		[RED("numberOfScreenshotRequestsForMainImage")] 
		public CInt32 NumberOfScreenshotRequestsForMainImage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(77)] 
		[RED("numberOfScreenshotRequestsForLeftImage")] 
		public CInt32 NumberOfScreenshotRequestsForLeftImage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(78)] 
		[RED("numberOfScreenshotRequestsForRightImage")] 
		public CInt32 NumberOfScreenshotRequestsForRightImage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ModDetailsItem()
		{
			ModName = new inkTextWidgetReference();
			ModioIcon = new inkImageWidgetReference();
			ModAuthorName = new inkTextWidgetReference();
			ModAuthorLinkedAccountName = new inkTextWidgetReference();
			ModioText = new inkTextWidgetReference();
			PlatformText = new inkTextWidgetReference();
			ModPlatformSeparator = new inkWidgetReference();
			Version = new inkTextWidgetReference();
			Changelog = new inkTextWidgetReference();
			Summary = new inkTextWidgetReference();
			Description = new inkTextWidgetReference();
			SubscriptionButton = new inkWidgetReference();
			LikeButton = new inkWidgetReference();
			AuthorButton = new inkWidgetReference();
			NumberOfLikesText = new inkTextWidgetReference();
			NumberOfLikesIcon = new inkImageWidgetReference();
			ModNumberOfDownloadsText = new inkTextWidgetReference();
			ModNumberOfDownloadsIcon = new inkImageWidgetReference();
			ModSizeText = new inkTextWidgetReference();
			ModSizeIcon = new inkImageWidgetReference();
			ModTooBigIcon = new inkImageWidgetReference();
			LastUpdatedTimeText = new inkTextWidgetReference();
			LastUpdatedTimeIcon = new inkImageWidgetReference();
			DownloadProgressBar = new inkCompoundWidgetReference();
			EmptyMainCarouselImage = new inkWidgetReference();
			EmptyLeftCarouselImage = new inkWidgetReference();
			EmptyRightCarouselImage = new inkWidgetReference();
			MainCarouselImage = new inkImageWidgetReference();
			LeftCarouselImage = new inkImageWidgetReference();
			RightCarouselImage = new inkImageWidgetReference();
			MainCarouselLoadingPanel = new inkWidgetReference();
			LeftCarouselLoadingPanel = new inkWidgetReference();
			RightCarouselLoadingPanel = new inkWidgetReference();
			LoadingFailedPanelWidget = new inkWidgetReference();
			MainCarouselImageController = new inkWidgetReference();
			LeftCarouselArrow = new inkWidgetReference();
			RightCarouselArrow = new inkWidgetReference();
			CarouselText = new inkTextWidgetReference();
			CarouselTextShadow = new inkTextWidgetReference();
			MoreOptionsDropdownListManagerRef = new inkWidgetReference();
			MoreOptionsDropdownButtonManagerRef = new inkWidgetReference();
			EmptyAnimationWidget = new inkWidgetReference();
			EmptyPreviewCanvas = new inkWidgetReference();
			TopEmptyPreviewImage = new inkWidgetReference();
			ButtonEmptyPreviewImage = new inkWidgetReference();
			MiddleEmptyPreviewImage = new inkWidgetReference();
			LineEmptyPreviewImage = new inkWidgetReference();
			BottomEmptyPreviewImage = new inkWidgetReference();
			InfoTitleEmptyPreviewImage = new inkWidgetReference();
			InfoDescEmptyPreviewImage = new inkWidgetReference();
			ModDetailsContent = new inkWidgetReference();
			TagsGridWidgetRef = new inkCompoundWidgetReference();
			PendingActivationOrDeactivationText = new inkTextWidgetReference();
			ScrollWidgetRef = new inkWidgetReference();
			EnableDisableToggleWidget = new inkWidgetReference();
			EnableDisableToggleText = new inkTextWidgetReference();
			EnableDisableToggleGradient = new inkWidgetReference();
			EnableDisableToggleUpperLine = new inkWidgetReference();
			EnableDisableToggleBottomLine = new inkWidgetReference();
			CarouselImagePaths = new();
			ColorNames = new ModsMenuColorsNames();
			TagsItemArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
