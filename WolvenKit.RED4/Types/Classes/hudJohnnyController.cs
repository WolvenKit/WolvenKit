using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudJohnnyController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("tourHeader")] 
		public inkTextWidgetReference TourHeader
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("leftDates")] 
		public inkTextWidgetReference LeftDates
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("rightDates")] 
		public inkTextWidgetReference RightDates
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("cancelled")] 
		public inkWidgetReference Cancelled
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		public hudJohnnyController()
		{
			TourHeader = new inkTextWidgetReference();
			LeftDates = new inkTextWidgetReference();
			RightDates = new inkTextWidgetReference();
			Cancelled = new inkWidgetReference();
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
