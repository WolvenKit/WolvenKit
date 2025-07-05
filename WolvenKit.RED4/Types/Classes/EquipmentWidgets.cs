using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipmentWidgets : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widgetArray")] 
		public CArray<inkWidgetReference> WidgetArray
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public EquipmentWidgets()
		{
			WidgetArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
