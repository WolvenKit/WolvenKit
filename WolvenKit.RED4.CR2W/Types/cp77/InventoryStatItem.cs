using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryStatItem : inkWidgetLogicController
	{
		private wCHandle<inkTextWidget> _label;
		private wCHandle<inkTextWidget> _value;

		[Ordinal(1)] 
		[RED("label")] 
		public wCHandle<inkTextWidget> Label
		{
			get
			{
				if (_label == null)
				{
					_label = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("value")] 
		public wCHandle<inkTextWidget> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		public InventoryStatItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
