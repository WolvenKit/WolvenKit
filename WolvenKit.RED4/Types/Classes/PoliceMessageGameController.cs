using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PoliceMessageGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("messageTextRef")] 
		public inkTextWidgetReference MessageTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(11)] 
		[RED("blackboardDef")] 
		public CHandle<UI_NotificationsDef> BlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_NotificationsDef>>();
			set => SetPropertyValue<CHandle<UI_NotificationsDef>>(value);
		}

		[Ordinal(12)] 
		[RED("warningMessageCallbackId")] 
		public CHandle<redCallbackObject> WarningMessageCallbackId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("simpleMessage")] 
		public gameSimpleScreenMessage SimpleMessage
		{
			get => GetPropertyValue<gameSimpleScreenMessage>();
			set => SetPropertyValue<gameSimpleScreenMessage>(value);
		}

		[Ordinal(14)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public PoliceMessageGameController()
		{
			MessageTextRef = new inkTextWidgetReference();
			SimpleMessage = new gameSimpleScreenMessage();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
