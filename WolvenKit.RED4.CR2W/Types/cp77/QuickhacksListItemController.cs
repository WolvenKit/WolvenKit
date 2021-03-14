using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhacksListItemController : inkListItemController
	{
		private CFloat _expandAnimationDuration;
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _memoryValue;
		private inkCompoundWidgetReference _memoryCells;
		private inkWidgetReference _actionStateRoot;
		private inkTextWidgetReference _actionStateText;
		private inkWidgetReference _cooldownIcon;
		private inkTextWidgetReference _cooldownValue;
		private inkWidgetReference _descriptionSize;
		private inkWidgetReference _costReductionArrow;
		private CFloat _curveRadius;
		private CHandle<inkanimProxy> _selectedLoop;
		private CName _currentAnimationName;
		private CHandle<inkanimProxy> _choiceAccepted;
		private CHandle<inkanimController> _resizeAnim;
		private wCHandle<inkWidget> _root;
		private CHandle<QuickhackData> _data;
		private CBool _isSelected;
		private CBool _expanded;
		private Vector2 _cachedDescriptionSize;
		private inkMargin _defaultMargin;

		[Ordinal(16)] 
		[RED("expandAnimationDuration")] 
		public CFloat ExpandAnimationDuration
		{
			get
			{
				if (_expandAnimationDuration == null)
				{
					_expandAnimationDuration = (CFloat) CR2WTypeManager.Create("Float", "expandAnimationDuration", cr2w, this);
				}
				return _expandAnimationDuration;
			}
			set
			{
				if (_expandAnimationDuration == value)
				{
					return;
				}
				_expandAnimationDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get
			{
				if (_description == null)
				{
					_description = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("memoryValue")] 
		public inkTextWidgetReference MemoryValue
		{
			get
			{
				if (_memoryValue == null)
				{
					_memoryValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "memoryValue", cr2w, this);
				}
				return _memoryValue;
			}
			set
			{
				if (_memoryValue == value)
				{
					return;
				}
				_memoryValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("memoryCells")] 
		public inkCompoundWidgetReference MemoryCells
		{
			get
			{
				if (_memoryCells == null)
				{
					_memoryCells = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "memoryCells", cr2w, this);
				}
				return _memoryCells;
			}
			set
			{
				if (_memoryCells == value)
				{
					return;
				}
				_memoryCells = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("actionStateRoot")] 
		public inkWidgetReference ActionStateRoot
		{
			get
			{
				if (_actionStateRoot == null)
				{
					_actionStateRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "actionStateRoot", cr2w, this);
				}
				return _actionStateRoot;
			}
			set
			{
				if (_actionStateRoot == value)
				{
					return;
				}
				_actionStateRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("actionStateText")] 
		public inkTextWidgetReference ActionStateText
		{
			get
			{
				if (_actionStateText == null)
				{
					_actionStateText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "actionStateText", cr2w, this);
				}
				return _actionStateText;
			}
			set
			{
				if (_actionStateText == value)
				{
					return;
				}
				_actionStateText = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("cooldownIcon")] 
		public inkWidgetReference CooldownIcon
		{
			get
			{
				if (_cooldownIcon == null)
				{
					_cooldownIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "cooldownIcon", cr2w, this);
				}
				return _cooldownIcon;
			}
			set
			{
				if (_cooldownIcon == value)
				{
					return;
				}
				_cooldownIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("cooldownValue")] 
		public inkTextWidgetReference CooldownValue
		{
			get
			{
				if (_cooldownValue == null)
				{
					_cooldownValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "cooldownValue", cr2w, this);
				}
				return _cooldownValue;
			}
			set
			{
				if (_cooldownValue == value)
				{
					return;
				}
				_cooldownValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("descriptionSize")] 
		public inkWidgetReference DescriptionSize
		{
			get
			{
				if (_descriptionSize == null)
				{
					_descriptionSize = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionSize", cr2w, this);
				}
				return _descriptionSize;
			}
			set
			{
				if (_descriptionSize == value)
				{
					return;
				}
				_descriptionSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("costReductionArrow")] 
		public inkWidgetReference CostReductionArrow
		{
			get
			{
				if (_costReductionArrow == null)
				{
					_costReductionArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "costReductionArrow", cr2w, this);
				}
				return _costReductionArrow;
			}
			set
			{
				if (_costReductionArrow == value)
				{
					return;
				}
				_costReductionArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("curveRadius")] 
		public CFloat CurveRadius
		{
			get
			{
				if (_curveRadius == null)
				{
					_curveRadius = (CFloat) CR2WTypeManager.Create("Float", "curveRadius", cr2w, this);
				}
				return _curveRadius;
			}
			set
			{
				if (_curveRadius == value)
				{
					return;
				}
				_curveRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("selectedLoop")] 
		public CHandle<inkanimProxy> SelectedLoop
		{
			get
			{
				if (_selectedLoop == null)
				{
					_selectedLoop = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "selectedLoop", cr2w, this);
				}
				return _selectedLoop;
			}
			set
			{
				if (_selectedLoop == value)
				{
					return;
				}
				_selectedLoop = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("currentAnimationName")] 
		public CName CurrentAnimationName
		{
			get
			{
				if (_currentAnimationName == null)
				{
					_currentAnimationName = (CName) CR2WTypeManager.Create("CName", "currentAnimationName", cr2w, this);
				}
				return _currentAnimationName;
			}
			set
			{
				if (_currentAnimationName == value)
				{
					return;
				}
				_currentAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("choiceAccepted")] 
		public CHandle<inkanimProxy> ChoiceAccepted
		{
			get
			{
				if (_choiceAccepted == null)
				{
					_choiceAccepted = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "choiceAccepted", cr2w, this);
				}
				return _choiceAccepted;
			}
			set
			{
				if (_choiceAccepted == value)
				{
					return;
				}
				_choiceAccepted = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("resizeAnim")] 
		public CHandle<inkanimController> ResizeAnim
		{
			get
			{
				if (_resizeAnim == null)
				{
					_resizeAnim = (CHandle<inkanimController>) CR2WTypeManager.Create("handle:inkanimController", "resizeAnim", cr2w, this);
				}
				return _resizeAnim;
			}
			set
			{
				if (_resizeAnim == value)
				{
					return;
				}
				_resizeAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("data")] 
		public CHandle<QuickhackData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<QuickhackData>) CR2WTypeManager.Create("handle:QuickhackData", "data", cr2w, this);
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

		[Ordinal(34)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get
			{
				if (_isSelected == null)
				{
					_isSelected = (CBool) CR2WTypeManager.Create("Bool", "isSelected", cr2w, this);
				}
				return _isSelected;
			}
			set
			{
				if (_isSelected == value)
				{
					return;
				}
				_isSelected = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("expanded")] 
		public CBool Expanded
		{
			get
			{
				if (_expanded == null)
				{
					_expanded = (CBool) CR2WTypeManager.Create("Bool", "expanded", cr2w, this);
				}
				return _expanded;
			}
			set
			{
				if (_expanded == value)
				{
					return;
				}
				_expanded = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("cachedDescriptionSize")] 
		public Vector2 CachedDescriptionSize
		{
			get
			{
				if (_cachedDescriptionSize == null)
				{
					_cachedDescriptionSize = (Vector2) CR2WTypeManager.Create("Vector2", "cachedDescriptionSize", cr2w, this);
				}
				return _cachedDescriptionSize;
			}
			set
			{
				if (_cachedDescriptionSize == value)
				{
					return;
				}
				_cachedDescriptionSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get
			{
				if (_defaultMargin == null)
				{
					_defaultMargin = (inkMargin) CR2WTypeManager.Create("inkMargin", "defaultMargin", cr2w, this);
				}
				return _defaultMargin;
			}
			set
			{
				if (_defaultMargin == value)
				{
					return;
				}
				_defaultMargin = value;
				PropertySet(this);
			}
		}

		public QuickhacksListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
