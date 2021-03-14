using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipGrenadeInfoModule : ItemTooltipModuleController
	{
		private inkTextWidgetReference _headerText;
		private inkTextWidgetReference _totalDamageText;
		private inkTextWidgetReference _durationText;
		private inkTextWidgetReference _rangeText;
		private inkImageWidgetReference _deliveryIcon;
		private inkTextWidgetReference _deliveryText;

		[Ordinal(2)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get
			{
				if (_headerText == null)
				{
					_headerText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "headerText", cr2w, this);
				}
				return _headerText;
			}
			set
			{
				if (_headerText == value)
				{
					return;
				}
				_headerText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("totalDamageText")] 
		public inkTextWidgetReference TotalDamageText
		{
			get
			{
				if (_totalDamageText == null)
				{
					_totalDamageText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "totalDamageText", cr2w, this);
				}
				return _totalDamageText;
			}
			set
			{
				if (_totalDamageText == value)
				{
					return;
				}
				_totalDamageText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("durationText")] 
		public inkTextWidgetReference DurationText
		{
			get
			{
				if (_durationText == null)
				{
					_durationText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "durationText", cr2w, this);
				}
				return _durationText;
			}
			set
			{
				if (_durationText == value)
				{
					return;
				}
				_durationText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rangeText")] 
		public inkTextWidgetReference RangeText
		{
			get
			{
				if (_rangeText == null)
				{
					_rangeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "rangeText", cr2w, this);
				}
				return _rangeText;
			}
			set
			{
				if (_rangeText == value)
				{
					return;
				}
				_rangeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("deliveryIcon")] 
		public inkImageWidgetReference DeliveryIcon
		{
			get
			{
				if (_deliveryIcon == null)
				{
					_deliveryIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "deliveryIcon", cr2w, this);
				}
				return _deliveryIcon;
			}
			set
			{
				if (_deliveryIcon == value)
				{
					return;
				}
				_deliveryIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("deliveryText")] 
		public inkTextWidgetReference DeliveryText
		{
			get
			{
				if (_deliveryText == null)
				{
					_deliveryText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "deliveryText", cr2w, this);
				}
				return _deliveryText;
			}
			set
			{
				if (_deliveryText == value)
				{
					return;
				}
				_deliveryText = value;
				PropertySet(this);
			}
		}

		public ItemTooltipGrenadeInfoModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
