using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GOGProfileGameController : gameuiBaseGOGProfileController
	{
		[Ordinal(2)] 
		[RED("retryButton")] 
		public inkWidgetReference RetryButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("parentContainerWidget")] 
		public inkWidgetReference ParentContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("isFirstLogin")] 
		public CBool IsFirstLogin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("showingFirstLogin")] 
		public CBool ShowingFirstLogin
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("canRetry")] 
		public CBool CanRetry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("currentScreenType")] 
		public CEnum<GogPopupScreenType> CurrentScreenType
		{
			get => GetPropertyValue<CEnum<GogPopupScreenType>>();
			set => SetPropertyValue<CEnum<GogPopupScreenType>>(value);
		}

		[Ordinal(8)] 
		[RED("currentWidget")] 
		public CWeakHandle<inkWidget> CurrentWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(9)] 
		[RED("gogRewardsList")] 
		public CArray<CHandle<GogRewardEntryData>> GogRewardsList
		{
			get => GetPropertyValue<CArray<CHandle<GogRewardEntryData>>>();
			set => SetPropertyValue<CArray<CHandle<GogRewardEntryData>>>(value);
		}

		[Ordinal(10)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		public GOGProfileGameController()
		{
			RetryButton = new inkWidgetReference();
			ParentContainerWidget = new inkWidgetReference();
			GogRewardsList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
