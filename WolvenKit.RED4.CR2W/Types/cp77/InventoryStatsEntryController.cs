using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsEntryController : inkWidgetLogicController
	{
		private inkImageWidgetReference _iconWidget;
		private inkTextWidgetReference _labelWidget;
		private inkTextWidgetReference _valueWidget;

		[Ordinal(1)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get
			{
				if (_iconWidget == null)
				{
					_iconWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconWidget", cr2w, this);
				}
				return _iconWidget;
			}
			set
			{
				if (_iconWidget == value)
				{
					return;
				}
				_iconWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("labelWidget")] 
		public inkTextWidgetReference LabelWidget
		{
			get
			{
				if (_labelWidget == null)
				{
					_labelWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelWidget", cr2w, this);
				}
				return _labelWidget;
			}
			set
			{
				if (_labelWidget == value)
				{
					return;
				}
				_labelWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("valueWidget")] 
		public inkTextWidgetReference ValueWidget
		{
			get
			{
				if (_valueWidget == null)
				{
					_valueWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "valueWidget", cr2w, this);
				}
				return _valueWidget;
			}
			set
			{
				if (_valueWidget == value)
				{
					return;
				}
				_valueWidget = value;
				PropertySet(this);
			}
		}

		public InventoryStatsEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
