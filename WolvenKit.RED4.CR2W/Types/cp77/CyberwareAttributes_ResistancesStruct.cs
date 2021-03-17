using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_ResistancesStruct : CVariable
	{
		private inkFlexWidgetReference _widgetHealth;
		private inkFlexWidgetReference _widgetPhysical;
		private inkFlexWidgetReference _widgetThermal;
		private inkFlexWidgetReference _widgetEMP;
		private inkFlexWidgetReference _widgetChemical;
		private inkFlexWidgetReference _resistanceTooltip;

		[Ordinal(0)] 
		[RED("widgetHealth")] 
		public inkFlexWidgetReference WidgetHealth
		{
			get => GetProperty(ref _widgetHealth);
			set => SetProperty(ref _widgetHealth, value);
		}

		[Ordinal(1)] 
		[RED("widgetPhysical")] 
		public inkFlexWidgetReference WidgetPhysical
		{
			get => GetProperty(ref _widgetPhysical);
			set => SetProperty(ref _widgetPhysical, value);
		}

		[Ordinal(2)] 
		[RED("widgetThermal")] 
		public inkFlexWidgetReference WidgetThermal
		{
			get => GetProperty(ref _widgetThermal);
			set => SetProperty(ref _widgetThermal, value);
		}

		[Ordinal(3)] 
		[RED("widgetEMP")] 
		public inkFlexWidgetReference WidgetEMP
		{
			get => GetProperty(ref _widgetEMP);
			set => SetProperty(ref _widgetEMP, value);
		}

		[Ordinal(4)] 
		[RED("widgetChemical")] 
		public inkFlexWidgetReference WidgetChemical
		{
			get => GetProperty(ref _widgetChemical);
			set => SetProperty(ref _widgetChemical, value);
		}

		[Ordinal(5)] 
		[RED("resistanceTooltip")] 
		public inkFlexWidgetReference ResistanceTooltip
		{
			get => GetProperty(ref _resistanceTooltip);
			set => SetProperty(ref _resistanceTooltip, value);
		}

		public CyberwareAttributes_ResistancesStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
