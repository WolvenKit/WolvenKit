using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipRequirementsModule : NewItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("smartlinkGunWrapper")] 
		public inkWidgetReference SmartlinkGunWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public NewItemTooltipRequirementsModule()
		{
			SmartlinkGunWrapper = new inkWidgetReference();
			Line = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
