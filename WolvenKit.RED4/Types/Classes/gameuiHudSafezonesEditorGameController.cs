using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiHudSafezonesEditorGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("rootWidget")] 
		public inkCompoundWidgetReference RootWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("flexWidget")] 
		public inkCompoundWidgetReference FlexWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CWeakHandle<inkGameNotificationData> Data
		{
			get => GetPropertyValue<CWeakHandle<inkGameNotificationData>>();
			set => SetPropertyValue<CWeakHandle<inkGameNotificationData>>(value);
		}

		[Ordinal(6)] 
		[RED("c_adjustment_speed")] 
		public CFloat C_adjustment_speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("c_stick_dead_zone")] 
		public CFloat C_stick_dead_zone
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiHudSafezonesEditorGameController()
		{
			RootWidget = new inkCompoundWidgetReference();
			FlexWidget = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
