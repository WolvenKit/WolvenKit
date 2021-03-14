using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSelectorController : inkWidgetLogicController
	{
		private CInt32 _index;
		private CArray<CString> _values;
		private CBool _cycledNavigation;
		private inkSelectionChangeCallback _selectionChanged;
		private CName _labelPath;
		private CName _valuePath;
		private CName _leftArrowPath;
		private CName _rightArrowPath;
		private wCHandle<inkTextWidget> _label;
		private wCHandle<inkTextWidget> _value;
		private wCHandle<inkWidget> _leftArrow;
		private wCHandle<inkWidget> _rightArrow;
		private wCHandle<inkButtonController> _rightArrowButton;
		private wCHandle<inkButtonController> _leftArrowButton;

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("values")] 
		public CArray<CString> Values
		{
			get
			{
				if (_values == null)
				{
					_values = (CArray<CString>) CR2WTypeManager.Create("array:String", "values", cr2w, this);
				}
				return _values;
			}
			set
			{
				if (_values == value)
				{
					return;
				}
				_values = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cycledNavigation")] 
		public CBool CycledNavigation
		{
			get
			{
				if (_cycledNavigation == null)
				{
					_cycledNavigation = (CBool) CR2WTypeManager.Create("Bool", "cycledNavigation", cr2w, this);
				}
				return _cycledNavigation;
			}
			set
			{
				if (_cycledNavigation == value)
				{
					return;
				}
				_cycledNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("SelectionChanged")] 
		public inkSelectionChangeCallback SelectionChanged
		{
			get
			{
				if (_selectionChanged == null)
				{
					_selectionChanged = (inkSelectionChangeCallback) CR2WTypeManager.Create("inkSelectionChangeCallback", "SelectionChanged", cr2w, this);
				}
				return _selectionChanged;
			}
			set
			{
				if (_selectionChanged == value)
				{
					return;
				}
				_selectionChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("labelPath")] 
		public CName LabelPath
		{
			get
			{
				if (_labelPath == null)
				{
					_labelPath = (CName) CR2WTypeManager.Create("CName", "labelPath", cr2w, this);
				}
				return _labelPath;
			}
			set
			{
				if (_labelPath == value)
				{
					return;
				}
				_labelPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("valuePath")] 
		public CName ValuePath
		{
			get
			{
				if (_valuePath == null)
				{
					_valuePath = (CName) CR2WTypeManager.Create("CName", "valuePath", cr2w, this);
				}
				return _valuePath;
			}
			set
			{
				if (_valuePath == value)
				{
					return;
				}
				_valuePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("leftArrowPath")] 
		public CName LeftArrowPath
		{
			get
			{
				if (_leftArrowPath == null)
				{
					_leftArrowPath = (CName) CR2WTypeManager.Create("CName", "leftArrowPath", cr2w, this);
				}
				return _leftArrowPath;
			}
			set
			{
				if (_leftArrowPath == value)
				{
					return;
				}
				_leftArrowPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rightArrowPath")] 
		public CName RightArrowPath
		{
			get
			{
				if (_rightArrowPath == null)
				{
					_rightArrowPath = (CName) CR2WTypeManager.Create("CName", "rightArrowPath", cr2w, this);
				}
				return _rightArrowPath;
			}
			set
			{
				if (_rightArrowPath == value)
				{
					return;
				}
				_rightArrowPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("leftArrow")] 
		public wCHandle<inkWidget> LeftArrow
		{
			get
			{
				if (_leftArrow == null)
				{
					_leftArrow = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "leftArrow", cr2w, this);
				}
				return _leftArrow;
			}
			set
			{
				if (_leftArrow == value)
				{
					return;
				}
				_leftArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rightArrow")] 
		public wCHandle<inkWidget> RightArrow
		{
			get
			{
				if (_rightArrow == null)
				{
					_rightArrow = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rightArrow", cr2w, this);
				}
				return _rightArrow;
			}
			set
			{
				if (_rightArrow == value)
				{
					return;
				}
				_rightArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rightArrowButton")] 
		public wCHandle<inkButtonController> RightArrowButton
		{
			get
			{
				if (_rightArrowButton == null)
				{
					_rightArrowButton = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "rightArrowButton", cr2w, this);
				}
				return _rightArrowButton;
			}
			set
			{
				if (_rightArrowButton == value)
				{
					return;
				}
				_rightArrowButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("leftArrowButton")] 
		public wCHandle<inkButtonController> LeftArrowButton
		{
			get
			{
				if (_leftArrowButton == null)
				{
					_leftArrowButton = (wCHandle<inkButtonController>) CR2WTypeManager.Create("whandle:inkButtonController", "leftArrowButton", cr2w, this);
				}
				return _leftArrowButton;
			}
			set
			{
				if (_leftArrowButton == value)
				{
					return;
				}
				_leftArrowButton = value;
				PropertySet(this);
			}
		}

		public inkSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
