using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackFilterButtonController : inkWidgetLogicController
	{
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _text;
		private CEnum<ItemFilterCategory> _filterType;
		private CBool _active;
		private CBool _hovered;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("filterType")] 
		public CEnum<ItemFilterCategory> FilterType
		{
			get
			{
				if (_filterType == null)
				{
					_filterType = (CEnum<ItemFilterCategory>) CR2WTypeManager.Create("ItemFilterCategory", "filterType", cr2w, this);
				}
				return _filterType;
			}
			set
			{
				if (_filterType == value)
				{
					return;
				}
				_filterType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get
			{
				if (_hovered == null)
				{
					_hovered = (CBool) CR2WTypeManager.Create("Bool", "hovered", cr2w, this);
				}
				return _hovered;
			}
			set
			{
				if (_hovered == value)
				{
					return;
				}
				_hovered = value;
				PropertySet(this);
			}
		}

		public BackpackFilterButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
