using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialHubTimeSkipController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("gameTimeText")] 
		public inkTextWidgetReference GameTimeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("cantSkipTimeContainer")] 
		public inkWidgetReference CantSkipTimeContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("timeSkipButton")] 
		public inkWidgetReference TimeSkipButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("gameCtrlRef")] 
		public CWeakHandle<gameuiMenuGameController> GameCtrlRef
		{
			get => GetPropertyValue<CWeakHandle<gameuiMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiMenuGameController>>(value);
		}

		[Ordinal(5)] 
		[RED("timeSystem")] 
		public CWeakHandle<gameTimeSystem> TimeSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTimeSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTimeSystem>>(value);
		}

		[Ordinal(6)] 
		[RED("timeSkipPopupToken")] 
		public CHandle<inkGameNotificationToken> TimeSkipPopupToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(7)] 
		[RED("cantSkipTimeAnim")] 
		public CHandle<inkanimProxy> CantSkipTimeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(8)] 
		[RED("gameTimeTextParams")] 
		public CHandle<textTextParameterSet> GameTimeTextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(9)] 
		[RED("canSkipTime")] 
		public CBool CanSkipTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RadialHubTimeSkipController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
