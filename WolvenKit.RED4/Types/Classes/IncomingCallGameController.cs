using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IncomingCallGameController : gameuiNewPhoneRelatedHUDGameController
	{
		[Ordinal(15)] 
		[RED("contactNameWidget")] 
		public inkTextWidgetReference ContactNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("buttonHint")] 
		public inkWidgetReference ButtonHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("phoneBlackboard")] 
		public CWeakHandle<gameIBlackboard> PhoneBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(18)] 
		[RED("phoneBBDefinition")] 
		public CHandle<UI_ComDeviceDef> PhoneBBDefinition
		{
			get => GetPropertyValue<CHandle<UI_ComDeviceDef>>();
			set => SetPropertyValue<CHandle<UI_ComDeviceDef>>(value);
		}

		[Ordinal(19)] 
		[RED("phoneCallInfoBBID")] 
		public CHandle<redCallbackObject> PhoneCallInfoBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public IncomingCallGameController()
		{
			ContactNameWidget = new inkTextWidgetReference();
			ButtonHint = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
