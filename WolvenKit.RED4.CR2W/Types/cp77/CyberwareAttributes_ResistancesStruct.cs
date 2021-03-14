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
			get
			{
				if (_widgetHealth == null)
				{
					_widgetHealth = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "widgetHealth", cr2w, this);
				}
				return _widgetHealth;
			}
			set
			{
				if (_widgetHealth == value)
				{
					return;
				}
				_widgetHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("widgetPhysical")] 
		public inkFlexWidgetReference WidgetPhysical
		{
			get
			{
				if (_widgetPhysical == null)
				{
					_widgetPhysical = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "widgetPhysical", cr2w, this);
				}
				return _widgetPhysical;
			}
			set
			{
				if (_widgetPhysical == value)
				{
					return;
				}
				_widgetPhysical = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("widgetThermal")] 
		public inkFlexWidgetReference WidgetThermal
		{
			get
			{
				if (_widgetThermal == null)
				{
					_widgetThermal = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "widgetThermal", cr2w, this);
				}
				return _widgetThermal;
			}
			set
			{
				if (_widgetThermal == value)
				{
					return;
				}
				_widgetThermal = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("widgetEMP")] 
		public inkFlexWidgetReference WidgetEMP
		{
			get
			{
				if (_widgetEMP == null)
				{
					_widgetEMP = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "widgetEMP", cr2w, this);
				}
				return _widgetEMP;
			}
			set
			{
				if (_widgetEMP == value)
				{
					return;
				}
				_widgetEMP = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("widgetChemical")] 
		public inkFlexWidgetReference WidgetChemical
		{
			get
			{
				if (_widgetChemical == null)
				{
					_widgetChemical = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "widgetChemical", cr2w, this);
				}
				return _widgetChemical;
			}
			set
			{
				if (_widgetChemical == value)
				{
					return;
				}
				_widgetChemical = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("resistanceTooltip")] 
		public inkFlexWidgetReference ResistanceTooltip
		{
			get
			{
				if (_resistanceTooltip == null)
				{
					_resistanceTooltip = (inkFlexWidgetReference) CR2WTypeManager.Create("inkFlexWidgetReference", "resistanceTooltip", cr2w, this);
				}
				return _resistanceTooltip;
			}
			set
			{
				if (_resistanceTooltip == value)
				{
					return;
				}
				_resistanceTooltip = value;
				PropertySet(this);
			}
		}

		public CyberwareAttributes_ResistancesStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
