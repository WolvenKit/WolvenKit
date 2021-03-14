using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaterialTooltip : AGenericTooltipController
	{
		private inkWidgetReference _titleWrapper;
		private inkWidgetReference _descriptionWrapper;
		private inkWidgetReference _descriptionLine;
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _basePrice;
		private inkTextWidgetReference _price;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(2)] 
		[RED("titleWrapper")] 
		public inkWidgetReference TitleWrapper
		{
			get
			{
				if (_titleWrapper == null)
				{
					_titleWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "titleWrapper", cr2w, this);
				}
				return _titleWrapper;
			}
			set
			{
				if (_titleWrapper == value)
				{
					return;
				}
				_titleWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get
			{
				if (_descriptionWrapper == null)
				{
					_descriptionWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionWrapper", cr2w, this);
				}
				return _descriptionWrapper;
			}
			set
			{
				if (_descriptionWrapper == value)
				{
					return;
				}
				_descriptionWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("descriptionLine")] 
		public inkWidgetReference DescriptionLine
		{
			get
			{
				if (_descriptionLine == null)
				{
					_descriptionLine = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionLine", cr2w, this);
				}
				return _descriptionLine;
			}
			set
			{
				if (_descriptionLine == value)
				{
					return;
				}
				_descriptionLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("Title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("BasePrice")] 
		public inkTextWidgetReference BasePrice
		{
			get
			{
				if (_basePrice == null)
				{
					_basePrice = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "BasePrice", cr2w, this);
				}
				return _basePrice;
			}
			set
			{
				if (_basePrice == value)
				{
					return;
				}
				_basePrice = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Price")] 
		public inkTextWidgetReference Price
		{
			get
			{
				if (_price == null)
				{
					_price = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Price", cr2w, this);
				}
				return _price;
			}
			set
			{
				if (_price == value)
				{
					return;
				}
				_price = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		public MaterialTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
