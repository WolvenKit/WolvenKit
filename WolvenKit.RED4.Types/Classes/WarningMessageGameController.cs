using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WarningMessageGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("mainTextWidget")] 
		public inkTextWidgetReference MainTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("blackboardDef")] 
		public CHandle<UI_NotificationsDef> BlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_NotificationsDef>>();
			set => SetPropertyValue<CHandle<UI_NotificationsDef>>(value);
		}

		[Ordinal(13)] 
		[RED("warningMessageCallbackId")] 
		public CHandle<redCallbackObject> WarningMessageCallbackId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("simpleMessage")] 
		public gameSimpleScreenMessage SimpleMessage
		{
			get => GetPropertyValue<gameSimpleScreenMessage>();
			set => SetPropertyValue<gameSimpleScreenMessage>(value);
		}

		[Ordinal(15)] 
		[RED("blinkingAnim")] 
		public CHandle<inkanimDefinition> BlinkingAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(16)] 
		[RED("showAnim")] 
		public CHandle<inkanimDefinition> ShowAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(17)] 
		[RED("hideAnim")] 
		public CHandle<inkanimDefinition> HideAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(18)] 
		[RED("animProxyShow")] 
		public CHandle<inkanimProxy> AnimProxyShow
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("animProxyHide")] 
		public CHandle<inkanimProxy> AnimProxyHide
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("animProxyTimeout")] 
		public CHandle<inkanimProxy> AnimProxyTimeout
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public WarningMessageGameController()
		{
			MainTextWidget = new();
			SimpleMessage = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
