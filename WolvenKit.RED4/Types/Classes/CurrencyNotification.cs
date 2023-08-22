using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CurrencyNotification : GenericNotificationController
	{
		[Ordinal(12)] 
		[RED("CurrencyUpdateAnimation")] 
		public CName CurrencyUpdateAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("CurrencyDiff")] 
		public inkTextWidgetReference CurrencyDiff
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("CurrencyTotal")] 
		public inkTextWidgetReference CurrencyTotal
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("total_animator")] 
		public CWeakHandle<inkTextValueProgressAnimationController> Total_animator
		{
			get => GetPropertyValue<CWeakHandle<inkTextValueProgressAnimationController>>();
			set => SetPropertyValue<CWeakHandle<inkTextValueProgressAnimationController>>(value);
		}

		[Ordinal(16)] 
		[RED("currencyData")] 
		public CHandle<gameuiCurrencyUpdateNotificationViewData> CurrencyData
		{
			get => GetPropertyValue<CHandle<gameuiCurrencyUpdateNotificationViewData>>();
			set => SetPropertyValue<CHandle<gameuiCurrencyUpdateNotificationViewData>>(value);
		}

		[Ordinal(17)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("animState")] 
		public CEnum<CurrencyNotificationAnimState> AnimState
		{
			get => GetPropertyValue<CEnum<CurrencyNotificationAnimState>>();
			set => SetPropertyValue<CEnum<CurrencyNotificationAnimState>>(value);
		}

		[Ordinal(19)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(20)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(21)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public CurrencyNotification()
		{
			CurrencyDiff = new inkTextWidgetReference();
			CurrencyTotal = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
