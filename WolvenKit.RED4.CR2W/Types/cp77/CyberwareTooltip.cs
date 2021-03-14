using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareTooltip : AGenericTooltipController
	{
		private inkCompoundWidgetReference _slotList;
		private inkTextWidgetReference _label;
		private CHandle<CyberwareTooltipData> _data;

		[Ordinal(2)] 
		[RED("slotList")] 
		public inkCompoundWidgetReference SlotList
		{
			get
			{
				if (_slotList == null)
				{
					_slotList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "slotList", cr2w, this);
				}
				return _slotList;
			}
			set
			{
				if (_slotList == value)
				{
					return;
				}
				_slotList = value;
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
		[RED("data")] 
		public CHandle<CyberwareTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<CyberwareTooltipData>) CR2WTypeManager.Create("handle:CyberwareTooltipData", "data", cr2w, this);
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

		public CyberwareTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
