using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationGenderBackstoryPathHeader : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _desc;
		private inkWidgetReference _bg;
		private CColor _selectedColor;
		private CColor _unSelectedColor;
		private CColor _textSelectedColor;
		private CColor _textUnselectedColor;

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

		[Ordinal(3)] 
		[RED("bg")] 
		public inkWidgetReference Bg
		{
			get
			{
				if (_bg == null)
				{
					_bg = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bg", cr2w, this);
				}
				return _bg;
			}
			set
			{
				if (_bg == value)
				{
					return;
				}
				_bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("selectedColor")] 
		public CColor SelectedColor
		{
			get
			{
				if (_selectedColor == null)
				{
					_selectedColor = (CColor) CR2WTypeManager.Create("Color", "selectedColor", cr2w, this);
				}
				return _selectedColor;
			}
			set
			{
				if (_selectedColor == value)
				{
					return;
				}
				_selectedColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("unSelectedColor")] 
		public CColor UnSelectedColor
		{
			get
			{
				if (_unSelectedColor == null)
				{
					_unSelectedColor = (CColor) CR2WTypeManager.Create("Color", "unSelectedColor", cr2w, this);
				}
				return _unSelectedColor;
			}
			set
			{
				if (_unSelectedColor == value)
				{
					return;
				}
				_unSelectedColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("textSelectedColor")] 
		public CColor TextSelectedColor
		{
			get
			{
				if (_textSelectedColor == null)
				{
					_textSelectedColor = (CColor) CR2WTypeManager.Create("Color", "textSelectedColor", cr2w, this);
				}
				return _textSelectedColor;
			}
			set
			{
				if (_textSelectedColor == value)
				{
					return;
				}
				_textSelectedColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("textUnselectedColor")] 
		public CColor TextUnselectedColor
		{
			get
			{
				if (_textUnselectedColor == null)
				{
					_textUnselectedColor = (CColor) CR2WTypeManager.Create("Color", "textUnselectedColor", cr2w, this);
				}
				return _textUnselectedColor;
			}
			set
			{
				if (_textUnselectedColor == value)
				{
					return;
				}
				_textUnselectedColor = value;
				PropertySet(this);
			}
		}

		public CharacterCreationGenderBackstoryPathHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
