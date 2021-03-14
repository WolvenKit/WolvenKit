using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLabelController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _moneyIcon;
		private CEnum<ItemLabelType> _type;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("moneyIcon")] 
		public inkImageWidgetReference MoneyIcon
		{
			get
			{
				if (_moneyIcon == null)
				{
					_moneyIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "moneyIcon", cr2w, this);
				}
				return _moneyIcon;
			}
			set
			{
				if (_moneyIcon == value)
				{
					return;
				}
				_moneyIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<ItemLabelType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<ItemLabelType>) CR2WTypeManager.Create("ItemLabelType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public ItemLabelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
