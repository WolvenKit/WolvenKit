using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipBottomModule : ItemTooltipModuleController
	{
		private inkWidgetReference _weightWrapper;
		private inkWidgetReference _priceWrapper;
		private inkTextWidgetReference _weightText;
		private inkTextWidgetReference _priceText;

		[Ordinal(2)] 
		[RED("weightWrapper")] 
		public inkWidgetReference WeightWrapper
		{
			get
			{
				if (_weightWrapper == null)
				{
					_weightWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "weightWrapper", cr2w, this);
				}
				return _weightWrapper;
			}
			set
			{
				if (_weightWrapper == value)
				{
					return;
				}
				_weightWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get
			{
				if (_priceWrapper == null)
				{
					_priceWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "priceWrapper", cr2w, this);
				}
				return _priceWrapper;
			}
			set
			{
				if (_priceWrapper == value)
				{
					return;
				}
				_priceWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weightText")] 
		public inkTextWidgetReference WeightText
		{
			get
			{
				if (_weightText == null)
				{
					_weightText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "weightText", cr2w, this);
				}
				return _weightText;
			}
			set
			{
				if (_weightText == value)
				{
					return;
				}
				_weightText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get
			{
				if (_priceText == null)
				{
					_priceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "priceText", cr2w, this);
				}
				return _priceText;
			}
			set
			{
				if (_priceText == value)
				{
					return;
				}
				_priceText = value;
				PropertySet(this);
			}
		}

		public ItemTooltipBottomModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
