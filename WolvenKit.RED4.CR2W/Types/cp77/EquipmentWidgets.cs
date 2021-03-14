using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentWidgets : CVariable
	{
		private CArray<inkWidgetReference> _widgetArray;

		[Ordinal(0)] 
		[RED("widgetArray")] 
		public CArray<inkWidgetReference> WidgetArray
		{
			get
			{
				if (_widgetArray == null)
				{
					_widgetArray = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "widgetArray", cr2w, this);
				}
				return _widgetArray;
			}
			set
			{
				if (_widgetArray == value)
				{
					return;
				}
				_widgetArray = value;
				PropertySet(this);
			}
		}

		public EquipmentWidgets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
