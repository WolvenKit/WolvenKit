using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SingleplayerMenuGameController : gameuiMainMenuGameController
	{
		[Ordinal(7)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("continuetooltipContainer")] 
		public inkCompoundWidgetReference ContinuetooltipContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("onlineSystem")] 
		public CWeakHandle<gameIOnlineSystem> OnlineSystem
		{
			get => GetPropertyValue<CWeakHandle<gameIOnlineSystem>>();
			set => SetPropertyValue<CWeakHandle<gameIOnlineSystem>>(value);
		}

		[Ordinal(11)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(13)] 
		[RED("continueGameTooltipController")] 
		public CWeakHandle<ContinueGameTooltip> ContinueGameTooltipController
		{
			get => GetPropertyValue<CWeakHandle<ContinueGameTooltip>>();
			set => SetPropertyValue<CWeakHandle<ContinueGameTooltip>>(value);
		}

		[Ordinal(14)] 
		[RED("dataSyncStatus")] 
		public CEnum<servicesCloudSavesQueryStatus> DataSyncStatus
		{
			get => GetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>();
			set => SetPropertyValue<CEnum<servicesCloudSavesQueryStatus>>(value);
		}

		[Ordinal(15)] 
		[RED("savesCount")] 
		public CInt32 SavesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("savesReady")] 
		public CBool SavesReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isModded")] 
		public CBool IsModded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SingleplayerMenuGameController()
		{
			ButtonHintsManagerRef = new();
			GogButtonWidgetRef = new();
			ContinuetooltipContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
