using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationStatsMenu : gameuiBaseCharacterCreationController
	{
		private inkWidgetReference _attribute_01;
		private inkWidgetReference _attribute_02;
		private inkWidgetReference _attribute_03;
		private inkWidgetReference _attribute_04;
		private inkWidgetReference _attribute_05;
		private inkWidgetReference _pointsLabel;
		private inkWidgetReference _tooltipSlot;
		private inkTextWidgetReference _skillPointLabel;
		private inkWidgetReference _reset;
		private inkWidgetReference _nextMenuConfirmation;
		private inkWidgetReference _nextMenukConfirmationLibraryWidget;
		private inkWidgetReference _confirmationConfirmBtn;
		private inkWidgetReference _confirmationCloseBtn;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _previousPageBtn;
		private inkWidgetReference _navigationButtons;
		private inkWidgetReference _optionSwitchHint;
		private CArray<CHandle<characterCreationStatsAttributeBtn>> _attributesControllers;
		private CInt32 _attributePointsAvailable;
		private CInt32 _startingAttributePoints;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private inkMargin _toolTipOffset;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _confirmAnimationProxy;
		private wCHandle<inkWidget> _hoverdWidget;

		[Ordinal(6)] 
		[RED("attribute_01")] 
		public inkWidgetReference Attribute_01
		{
			get
			{
				if (_attribute_01 == null)
				{
					_attribute_01 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attribute_01", cr2w, this);
				}
				return _attribute_01;
			}
			set
			{
				if (_attribute_01 == value)
				{
					return;
				}
				_attribute_01 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attribute_02")] 
		public inkWidgetReference Attribute_02
		{
			get
			{
				if (_attribute_02 == null)
				{
					_attribute_02 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attribute_02", cr2w, this);
				}
				return _attribute_02;
			}
			set
			{
				if (_attribute_02 == value)
				{
					return;
				}
				_attribute_02 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("attribute_03")] 
		public inkWidgetReference Attribute_03
		{
			get
			{
				if (_attribute_03 == null)
				{
					_attribute_03 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attribute_03", cr2w, this);
				}
				return _attribute_03;
			}
			set
			{
				if (_attribute_03 == value)
				{
					return;
				}
				_attribute_03 = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attribute_04")] 
		public inkWidgetReference Attribute_04
		{
			get
			{
				if (_attribute_04 == null)
				{
					_attribute_04 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attribute_04", cr2w, this);
				}
				return _attribute_04;
			}
			set
			{
				if (_attribute_04 == value)
				{
					return;
				}
				_attribute_04 = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("attribute_05")] 
		public inkWidgetReference Attribute_05
		{
			get
			{
				if (_attribute_05 == null)
				{
					_attribute_05 = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attribute_05", cr2w, this);
				}
				return _attribute_05;
			}
			set
			{
				if (_attribute_05 == value)
				{
					return;
				}
				_attribute_05 = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("pointsLabel")] 
		public inkWidgetReference PointsLabel
		{
			get
			{
				if (_pointsLabel == null)
				{
					_pointsLabel = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pointsLabel", cr2w, this);
				}
				return _pointsLabel;
			}
			set
			{
				if (_pointsLabel == value)
				{
					return;
				}
				_pointsLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("tooltipSlot")] 
		public inkWidgetReference TooltipSlot
		{
			get
			{
				if (_tooltipSlot == null)
				{
					_tooltipSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipSlot", cr2w, this);
				}
				return _tooltipSlot;
			}
			set
			{
				if (_tooltipSlot == value)
				{
					return;
				}
				_tooltipSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("skillPointLabel")] 
		public inkTextWidgetReference SkillPointLabel
		{
			get
			{
				if (_skillPointLabel == null)
				{
					_skillPointLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "skillPointLabel", cr2w, this);
				}
				return _skillPointLabel;
			}
			set
			{
				if (_skillPointLabel == value)
				{
					return;
				}
				_skillPointLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("reset")] 
		public inkWidgetReference Reset
		{
			get
			{
				if (_reset == null)
				{
					_reset = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "reset", cr2w, this);
				}
				return _reset;
			}
			set
			{
				if (_reset == value)
				{
					return;
				}
				_reset = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("nextMenuConfirmation")] 
		public inkWidgetReference NextMenuConfirmation
		{
			get
			{
				if (_nextMenuConfirmation == null)
				{
					_nextMenuConfirmation = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nextMenuConfirmation", cr2w, this);
				}
				return _nextMenuConfirmation;
			}
			set
			{
				if (_nextMenuConfirmation == value)
				{
					return;
				}
				_nextMenuConfirmation = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("nextMenukConfirmationLibraryWidget")] 
		public inkWidgetReference NextMenukConfirmationLibraryWidget
		{
			get
			{
				if (_nextMenukConfirmationLibraryWidget == null)
				{
					_nextMenukConfirmationLibraryWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nextMenukConfirmationLibraryWidget", cr2w, this);
				}
				return _nextMenukConfirmationLibraryWidget;
			}
			set
			{
				if (_nextMenukConfirmationLibraryWidget == value)
				{
					return;
				}
				_nextMenukConfirmationLibraryWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ConfirmationConfirmBtn")] 
		public inkWidgetReference ConfirmationConfirmBtn
		{
			get
			{
				if (_confirmationConfirmBtn == null)
				{
					_confirmationConfirmBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ConfirmationConfirmBtn", cr2w, this);
				}
				return _confirmationConfirmBtn;
			}
			set
			{
				if (_confirmationConfirmBtn == value)
				{
					return;
				}
				_confirmationConfirmBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ConfirmationCloseBtn")] 
		public inkWidgetReference ConfirmationCloseBtn
		{
			get
			{
				if (_confirmationCloseBtn == null)
				{
					_confirmationCloseBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ConfirmationCloseBtn", cr2w, this);
				}
				return _confirmationCloseBtn;
			}
			set
			{
				if (_confirmationCloseBtn == value)
				{
					return;
				}
				_confirmationCloseBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("previousPageBtn")] 
		public inkWidgetReference PreviousPageBtn
		{
			get
			{
				if (_previousPageBtn == null)
				{
					_previousPageBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "previousPageBtn", cr2w, this);
				}
				return _previousPageBtn;
			}
			set
			{
				if (_previousPageBtn == value)
				{
					return;
				}
				_previousPageBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("navigationButtons")] 
		public inkWidgetReference NavigationButtons
		{
			get
			{
				if (_navigationButtons == null)
				{
					_navigationButtons = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "navigationButtons", cr2w, this);
				}
				return _navigationButtons;
			}
			set
			{
				if (_navigationButtons == value)
				{
					return;
				}
				_navigationButtons = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("optionSwitchHint")] 
		public inkWidgetReference OptionSwitchHint
		{
			get
			{
				if (_optionSwitchHint == null)
				{
					_optionSwitchHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "optionSwitchHint", cr2w, this);
				}
				return _optionSwitchHint;
			}
			set
			{
				if (_optionSwitchHint == value)
				{
					return;
				}
				_optionSwitchHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("attributesControllers")] 
		public CArray<CHandle<characterCreationStatsAttributeBtn>> AttributesControllers
		{
			get
			{
				if (_attributesControllers == null)
				{
					_attributesControllers = (CArray<CHandle<characterCreationStatsAttributeBtn>>) CR2WTypeManager.Create("array:handle:characterCreationStatsAttributeBtn", "attributesControllers", cr2w, this);
				}
				return _attributesControllers;
			}
			set
			{
				if (_attributesControllers == value)
				{
					return;
				}
				_attributesControllers = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("attributePointsAvailable")] 
		public CInt32 AttributePointsAvailable
		{
			get
			{
				if (_attributePointsAvailable == null)
				{
					_attributePointsAvailable = (CInt32) CR2WTypeManager.Create("Int32", "attributePointsAvailable", cr2w, this);
				}
				return _attributePointsAvailable;
			}
			set
			{
				if (_attributePointsAvailable == value)
				{
					return;
				}
				_attributePointsAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("startingAttributePoints")] 
		public CInt32 StartingAttributePoints
		{
			get
			{
				if (_startingAttributePoints == null)
				{
					_startingAttributePoints = (CInt32) CR2WTypeManager.Create("Int32", "startingAttributePoints", cr2w, this);
				}
				return _startingAttributePoints;
			}
			set
			{
				if (_startingAttributePoints == value)
				{
					return;
				}
				_startingAttributePoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("toolTipOffset")] 
		public inkMargin ToolTipOffset
		{
			get
			{
				if (_toolTipOffset == null)
				{
					_toolTipOffset = (inkMargin) CR2WTypeManager.Create("inkMargin", "toolTipOffset", cr2w, this);
				}
				return _toolTipOffset;
			}
			set
			{
				if (_toolTipOffset == value)
				{
					return;
				}
				_toolTipOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get
			{
				if (_animationProxy == null)
				{
					_animationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animationProxy", cr2w, this);
				}
				return _animationProxy;
			}
			set
			{
				if (_animationProxy == value)
				{
					return;
				}
				_animationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("confirmAnimationProxy")] 
		public CHandle<inkanimProxy> ConfirmAnimationProxy
		{
			get
			{
				if (_confirmAnimationProxy == null)
				{
					_confirmAnimationProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "confirmAnimationProxy", cr2w, this);
				}
				return _confirmAnimationProxy;
			}
			set
			{
				if (_confirmAnimationProxy == value)
				{
					return;
				}
				_confirmAnimationProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("hoverdWidget")] 
		public wCHandle<inkWidget> HoverdWidget
		{
			get
			{
				if (_hoverdWidget == null)
				{
					_hoverdWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "hoverdWidget", cr2w, this);
				}
				return _hoverdWidget;
			}
			set
			{
				if (_hoverdWidget == value)
				{
					return;
				}
				_hoverdWidget = value;
				PropertySet(this);
			}
		}

		public CharacterCreationStatsMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
