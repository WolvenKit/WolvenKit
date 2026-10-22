using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogUserDisplayController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("cdprAccountName")] 
		public inkTextWidgetReference CdprAccountName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("platformAccountName")] 
		public inkTextWidgetReference PlatformAccountName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("platformAccountIcon")] 
		public inkImageWidgetReference PlatformAccountIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("requestHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		public GogUserDisplayController()
		{
			CdprAccountName = new inkTextWidgetReference();
			PlatformAccountName = new inkTextWidgetReference();
			PlatformAccountIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
