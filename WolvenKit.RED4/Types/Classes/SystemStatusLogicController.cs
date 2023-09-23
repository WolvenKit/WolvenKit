using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SystemStatusLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("onlineRoot")] 
		public inkWidgetReference OnlineRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("offlineRoot")] 
		public inkWidgetReference OfflineRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("onlineIco")] 
		public inkWidgetReference OnlineIco
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("offlineIco")] 
		public inkWidgetReference OfflineIco
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("sysIndicator")] 
		public inkWidgetReference SysIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("statusBackground")] 
		public inkWidgetReference StatusBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("statusBackgroundProxy")] 
		public CHandle<inkanimProxy> StatusBackgroundProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(8)] 
		[RED("stateAnimName")] 
		public CName StateAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("widgetsToColor")] 
		public CArray<inkWidgetReference> WidgetsToColor
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(10)] 
		[RED("textStatuses")] 
		public CArray<inkTextWidgetReference> TextStatuses
		{
			get => GetPropertyValue<CArray<inkTextWidgetReference>>();
			set => SetPropertyValue<CArray<inkTextWidgetReference>>(value);
		}

		public SystemStatusLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
