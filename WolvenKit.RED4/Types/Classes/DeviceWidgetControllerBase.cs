using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceWidgetControllerBase : DeviceInkLogicControllerBase
	{
		[Ordinal(5)] 
		[RED("backgroundTextureRef")] 
		public inkImageWidgetReference BackgroundTextureRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("statusNameWidget")] 
		public inkTextWidgetReference StatusNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("actionsListWidget")] 
		public inkWidgetReference ActionsListWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("actionWidgetsData")] 
		public CArray<SActionWidgetPackage> ActionWidgetsData
		{
			get => GetPropertyValue<CArray<SActionWidgetPackage>>();
			set => SetPropertyValue<CArray<SActionWidgetPackage>>(value);
		}

		[Ordinal(9)] 
		[RED("actionData")] 
		public CHandle<ResolveActionData> ActionData
		{
			get => GetPropertyValue<CHandle<ResolveActionData>>();
			set => SetPropertyValue<CHandle<ResolveActionData>>(value);
		}

		public DeviceWidgetControllerBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
