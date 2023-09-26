using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InnerBunkerSystemStatusLogicController : inkWidgetLogicController
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
		[RED("stateAnimName")] 
		public CName StateAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("widgetsToColor")] 
		public CArray<inkWidgetReference> WidgetsToColor
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(8)] 
		[RED("textStatuses")] 
		public CArray<inkTextWidgetReference> TextStatuses
		{
			get => GetPropertyValue<CArray<inkTextWidgetReference>>();
			set => SetPropertyValue<CArray<inkTextWidgetReference>>(value);
		}

		public InnerBunkerSystemStatusLogicController()
		{
			OnlineRoot = new inkWidgetReference();
			OfflineRoot = new inkWidgetReference();
			OnlineIco = new inkWidgetReference();
			OfflineIco = new inkWidgetReference();
			SysIndicator = new inkWidgetReference();
			WidgetsToColor = new();
			TextStatuses = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
