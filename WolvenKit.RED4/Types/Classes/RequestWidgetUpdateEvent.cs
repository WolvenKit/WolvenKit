using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestWidgetUpdateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requester")] 
		public gamePersistentID Requester
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("screenDefinition")] 
		public ScreenDefinitionPackage ScreenDefinition
		{
			get => GetPropertyValue<ScreenDefinitionPackage>();
			set => SetPropertyValue<ScreenDefinitionPackage>(value);
		}

		public RequestWidgetUpdateEvent()
		{
			Requester = new gamePersistentID();
			ScreenDefinition = new ScreenDefinitionPackage();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
