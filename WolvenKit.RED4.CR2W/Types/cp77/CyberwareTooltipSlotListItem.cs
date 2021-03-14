using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltipSlotListItem : AGenericTooltipController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _desc;
		private CHandle<CyberwareSlotTooltipData> _data;

		[Ordinal(2)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
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

		[Ordinal(4)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get
			{
				if (_desc == null)
				{
					_desc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "desc", cr2w, this);
				}
				return _desc;
			}
			set
			{
				if (_desc == value)
				{
					return;
				}
				_desc = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<CyberwareSlotTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<CyberwareSlotTooltipData>) CR2WTypeManager.Create("handle:CyberwareSlotTooltipData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public CyberwareTooltipSlotListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
