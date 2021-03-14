using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TabButtonController : inkToggleController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private CInt32 _data;
		private CString _labelSet;
		private CString _iconSet;

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("data")] 
		public CInt32 Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CInt32) CR2WTypeManager.Create("Int32", "data", cr2w, this);
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

		[Ordinal(16)] 
		[RED("labelSet")] 
		public CString LabelSet
		{
			get
			{
				if (_labelSet == null)
				{
					_labelSet = (CString) CR2WTypeManager.Create("String", "labelSet", cr2w, this);
				}
				return _labelSet;
			}
			set
			{
				if (_labelSet == value)
				{
					return;
				}
				_labelSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("iconSet")] 
		public CString IconSet
		{
			get
			{
				if (_iconSet == null)
				{
					_iconSet = (CString) CR2WTypeManager.Create("String", "iconSet", cr2w, this);
				}
				return _iconSet;
			}
			set
			{
				if (_iconSet == value)
				{
					return;
				}
				_iconSet = value;
				PropertySet(this);
			}
		}

		public TabButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
