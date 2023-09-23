using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingControllerScheme : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("inputTab")] 
		public inkWidgetReference InputTab
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("vehiclesTab")] 
		public inkWidgetReference VehiclesTab
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("braindanceTab")] 
		public inkWidgetReference BraindanceTab
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("tabRoot")] 
		public CWeakHandle<TabRadioGroup> TabRoot
		{
			get => GetPropertyValue<CWeakHandle<TabRadioGroup>>();
			set => SetPropertyValue<CWeakHandle<TabRadioGroup>>(value);
		}

		public SettingControllerScheme()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
