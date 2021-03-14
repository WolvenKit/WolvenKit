using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationStatsAttributeBtn : inkWidgetLogicController
	{
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _label;
		private inkWidgetReference _addBtn;
		private inkWidgetReference _addBtnhitArea;
		private inkWidgetReference _minusBtn;
		private inkWidgetReference _minusBtnhitArea;
		private inkWidgetReference _minMaxLabel;
		private inkTextWidgetReference _minMaxLabelText;
		private inkWidgetReference _minusBtnNONE;
		private inkWidgetReference _addBtnNONE;
		private CHandle<CharacterCreationAttributeData> _data;
		private CBool _animating;
		private CBool _minusEnabled;
		private CBool _addEnabled;
		private CBool _maxed;
		private CEnum<AttributeButtonState> _addBtnState;
		private CEnum<AttributeButtonState> _minusBtnState;
		private CEnum<AttributeButtonState> _state;

		[Ordinal(1)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get
			{
				if (_value == null)
				{
					_value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value", cr2w, this);
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("addBtn")] 
		public inkWidgetReference AddBtn
		{
			get
			{
				if (_addBtn == null)
				{
					_addBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "addBtn", cr2w, this);
				}
				return _addBtn;
			}
			set
			{
				if (_addBtn == value)
				{
					return;
				}
				_addBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("addBtnhitArea")] 
		public inkWidgetReference AddBtnhitArea
		{
			get
			{
				if (_addBtnhitArea == null)
				{
					_addBtnhitArea = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "addBtnhitArea", cr2w, this);
				}
				return _addBtnhitArea;
			}
			set
			{
				if (_addBtnhitArea == value)
				{
					return;
				}
				_addBtnhitArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("minusBtn")] 
		public inkWidgetReference MinusBtn
		{
			get
			{
				if (_minusBtn == null)
				{
					_minusBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "minusBtn", cr2w, this);
				}
				return _minusBtn;
			}
			set
			{
				if (_minusBtn == value)
				{
					return;
				}
				_minusBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("minusBtnhitArea")] 
		public inkWidgetReference MinusBtnhitArea
		{
			get
			{
				if (_minusBtnhitArea == null)
				{
					_minusBtnhitArea = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "minusBtnhitArea", cr2w, this);
				}
				return _minusBtnhitArea;
			}
			set
			{
				if (_minusBtnhitArea == value)
				{
					return;
				}
				_minusBtnhitArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("minMaxLabel")] 
		public inkWidgetReference MinMaxLabel
		{
			get
			{
				if (_minMaxLabel == null)
				{
					_minMaxLabel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "minMaxLabel", cr2w, this);
				}
				return _minMaxLabel;
			}
			set
			{
				if (_minMaxLabel == value)
				{
					return;
				}
				_minMaxLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("minMaxLabelText")] 
		public inkTextWidgetReference MinMaxLabelText
		{
			get
			{
				if (_minMaxLabelText == null)
				{
					_minMaxLabelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "minMaxLabelText", cr2w, this);
				}
				return _minMaxLabelText;
			}
			set
			{
				if (_minMaxLabelText == value)
				{
					return;
				}
				_minMaxLabelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("minusBtnNONE")] 
		public inkWidgetReference MinusBtnNONE
		{
			get
			{
				if (_minusBtnNONE == null)
				{
					_minusBtnNONE = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "minusBtnNONE", cr2w, this);
				}
				return _minusBtnNONE;
			}
			set
			{
				if (_minusBtnNONE == value)
				{
					return;
				}
				_minusBtnNONE = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("addBtnNONE")] 
		public inkWidgetReference AddBtnNONE
		{
			get
			{
				if (_addBtnNONE == null)
				{
					_addBtnNONE = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "addBtnNONE", cr2w, this);
				}
				return _addBtnNONE;
			}
			set
			{
				if (_addBtnNONE == value)
				{
					return;
				}
				_addBtnNONE = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<CharacterCreationAttributeData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<CharacterCreationAttributeData>) CR2WTypeManager.Create("handle:CharacterCreationAttributeData", "data", cr2w, this);
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

		[Ordinal(12)] 
		[RED("animating")] 
		public CBool Animating
		{
			get
			{
				if (_animating == null)
				{
					_animating = (CBool) CR2WTypeManager.Create("Bool", "animating", cr2w, this);
				}
				return _animating;
			}
			set
			{
				if (_animating == value)
				{
					return;
				}
				_animating = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("minusEnabled")] 
		public CBool MinusEnabled
		{
			get
			{
				if (_minusEnabled == null)
				{
					_minusEnabled = (CBool) CR2WTypeManager.Create("Bool", "minusEnabled", cr2w, this);
				}
				return _minusEnabled;
			}
			set
			{
				if (_minusEnabled == value)
				{
					return;
				}
				_minusEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("addEnabled")] 
		public CBool AddEnabled
		{
			get
			{
				if (_addEnabled == null)
				{
					_addEnabled = (CBool) CR2WTypeManager.Create("Bool", "addEnabled", cr2w, this);
				}
				return _addEnabled;
			}
			set
			{
				if (_addEnabled == value)
				{
					return;
				}
				_addEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("maxed")] 
		public CBool Maxed
		{
			get
			{
				if (_maxed == null)
				{
					_maxed = (CBool) CR2WTypeManager.Create("Bool", "maxed", cr2w, this);
				}
				return _maxed;
			}
			set
			{
				if (_maxed == value)
				{
					return;
				}
				_maxed = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("addBtnState")] 
		public CEnum<AttributeButtonState> AddBtnState
		{
			get
			{
				if (_addBtnState == null)
				{
					_addBtnState = (CEnum<AttributeButtonState>) CR2WTypeManager.Create("AttributeButtonState", "addBtnState", cr2w, this);
				}
				return _addBtnState;
			}
			set
			{
				if (_addBtnState == value)
				{
					return;
				}
				_addBtnState = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("minusBtnState")] 
		public CEnum<AttributeButtonState> MinusBtnState
		{
			get
			{
				if (_minusBtnState == null)
				{
					_minusBtnState = (CEnum<AttributeButtonState>) CR2WTypeManager.Create("AttributeButtonState", "minusBtnState", cr2w, this);
				}
				return _minusBtnState;
			}
			set
			{
				if (_minusBtnState == value)
				{
					return;
				}
				_minusBtnState = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("state")] 
		public CEnum<AttributeButtonState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<AttributeButtonState>) CR2WTypeManager.Create("AttributeButtonState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public characterCreationStatsAttributeBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
