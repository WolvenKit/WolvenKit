using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareAttributes_ResistancesStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widgetHealth")] 
		public inkFlexWidgetReference WidgetHealth
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("widgetPhysical")] 
		public inkFlexWidgetReference WidgetPhysical
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("widgetThermal")] 
		public inkFlexWidgetReference WidgetThermal
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("widgetEMP")] 
		public inkFlexWidgetReference WidgetEMP
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("widgetChemical")] 
		public inkFlexWidgetReference WidgetChemical
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("resistanceTooltip")] 
		public inkFlexWidgetReference ResistanceTooltip
		{
			get => GetPropertyValue<inkFlexWidgetReference>();
			set => SetPropertyValue<inkFlexWidgetReference>(value);
		}

		public CyberwareAttributes_ResistancesStruct()
		{
			WidgetHealth = new inkFlexWidgetReference();
			WidgetPhysical = new inkFlexWidgetReference();
			WidgetThermal = new inkFlexWidgetReference();
			WidgetEMP = new inkFlexWidgetReference();
			WidgetChemical = new inkFlexWidgetReference();
			ResistanceTooltip = new inkFlexWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
