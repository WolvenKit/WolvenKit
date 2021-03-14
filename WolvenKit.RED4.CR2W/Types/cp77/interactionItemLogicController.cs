using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interactionItemLogicController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _inputButtonContainer;
		private inkWidgetReference _inputDisplayControllerRef;
		private inkWidgetReference _quickHackCostHolder;
		private inkTextWidgetReference _quickHackCost;
		private inkImageWidgetReference _quickHackIcon;
		private inkCompoundWidgetReference _quickHackHolder;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _labelFail;
		private inkWidgetReference _skillCheckPassBG;
		private inkWidgetReference _skillCheckFailBG;
		private inkWidgetReference _qHIllegalIndicator;
		private inkWidgetReference _sCIllegalIndicator;
		private inkWidgetReference _additionalReqsNeeded;
		private inkCompoundWidgetReference _skillCheck;
		private inkCompoundWidgetReference _skillCheckNormalReqs;
		private inkImageWidgetReference _skillCheckIcon;
		private inkTextWidgetReference _skillCheckText;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private CFloat _inActiveTransparency;
		private wCHandle<inkInputDisplayController> _inputDisplayController;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _isSelected;

		[Ordinal(1)] 
		[RED("inputButtonContainer")] 
		public inkCompoundWidgetReference InputButtonContainer
		{
			get
			{
				if (_inputButtonContainer == null)
				{
					_inputButtonContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "inputButtonContainer", cr2w, this);
				}
				return _inputButtonContainer;
			}
			set
			{
				if (_inputButtonContainer == value)
				{
					return;
				}
				_inputButtonContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inputDisplayControllerRef")] 
		public inkWidgetReference InputDisplayControllerRef
		{
			get
			{
				if (_inputDisplayControllerRef == null)
				{
					_inputDisplayControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputDisplayControllerRef", cr2w, this);
				}
				return _inputDisplayControllerRef;
			}
			set
			{
				if (_inputDisplayControllerRef == value)
				{
					return;
				}
				_inputDisplayControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("QuickHackCostHolder")] 
		public inkWidgetReference QuickHackCostHolder
		{
			get
			{
				if (_quickHackCostHolder == null)
				{
					_quickHackCostHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "QuickHackCostHolder", cr2w, this);
				}
				return _quickHackCostHolder;
			}
			set
			{
				if (_quickHackCostHolder == value)
				{
					return;
				}
				_quickHackCostHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("QuickHackCost")] 
		public inkTextWidgetReference QuickHackCost
		{
			get
			{
				if (_quickHackCost == null)
				{
					_quickHackCost = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "QuickHackCost", cr2w, this);
				}
				return _quickHackCost;
			}
			set
			{
				if (_quickHackCost == value)
				{
					return;
				}
				_quickHackCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("QuickHackIcon")] 
		public inkImageWidgetReference QuickHackIcon
		{
			get
			{
				if (_quickHackIcon == null)
				{
					_quickHackIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "QuickHackIcon", cr2w, this);
				}
				return _quickHackIcon;
			}
			set
			{
				if (_quickHackIcon == value)
				{
					return;
				}
				_quickHackIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("QuickHackHolder")] 
		public inkCompoundWidgetReference QuickHackHolder
		{
			get
			{
				if (_quickHackHolder == null)
				{
					_quickHackHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "QuickHackHolder", cr2w, this);
				}
				return _quickHackHolder;
			}
			set
			{
				if (_quickHackHolder == value)
				{
					return;
				}
				_quickHackHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("labelFail")] 
		public inkTextWidgetReference LabelFail
		{
			get
			{
				if (_labelFail == null)
				{
					_labelFail = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelFail", cr2w, this);
				}
				return _labelFail;
			}
			set
			{
				if (_labelFail == value)
				{
					return;
				}
				_labelFail = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("SkillCheckPassBG")] 
		public inkWidgetReference SkillCheckPassBG
		{
			get
			{
				if (_skillCheckPassBG == null)
				{
					_skillCheckPassBG = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SkillCheckPassBG", cr2w, this);
				}
				return _skillCheckPassBG;
			}
			set
			{
				if (_skillCheckPassBG == value)
				{
					return;
				}
				_skillCheckPassBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("SkillCheckFailBG")] 
		public inkWidgetReference SkillCheckFailBG
		{
			get
			{
				if (_skillCheckFailBG == null)
				{
					_skillCheckFailBG = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SkillCheckFailBG", cr2w, this);
				}
				return _skillCheckFailBG;
			}
			set
			{
				if (_skillCheckFailBG == value)
				{
					return;
				}
				_skillCheckFailBG = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("QHIllegalIndicator")] 
		public inkWidgetReference QHIllegalIndicator
		{
			get
			{
				if (_qHIllegalIndicator == null)
				{
					_qHIllegalIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "QHIllegalIndicator", cr2w, this);
				}
				return _qHIllegalIndicator;
			}
			set
			{
				if (_qHIllegalIndicator == value)
				{
					return;
				}
				_qHIllegalIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("SCIllegalIndicator")] 
		public inkWidgetReference SCIllegalIndicator
		{
			get
			{
				if (_sCIllegalIndicator == null)
				{
					_sCIllegalIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SCIllegalIndicator", cr2w, this);
				}
				return _sCIllegalIndicator;
			}
			set
			{
				if (_sCIllegalIndicator == value)
				{
					return;
				}
				_sCIllegalIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("additionalReqsNeeded")] 
		public inkWidgetReference AdditionalReqsNeeded
		{
			get
			{
				if (_additionalReqsNeeded == null)
				{
					_additionalReqsNeeded = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "additionalReqsNeeded", cr2w, this);
				}
				return _additionalReqsNeeded;
			}
			set
			{
				if (_additionalReqsNeeded == value)
				{
					return;
				}
				_additionalReqsNeeded = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("skillCheck")] 
		public inkCompoundWidgetReference SkillCheck
		{
			get
			{
				if (_skillCheck == null)
				{
					_skillCheck = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "skillCheck", cr2w, this);
				}
				return _skillCheck;
			}
			set
			{
				if (_skillCheck == value)
				{
					return;
				}
				_skillCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("skillCheckNormalReqs")] 
		public inkCompoundWidgetReference SkillCheckNormalReqs
		{
			get
			{
				if (_skillCheckNormalReqs == null)
				{
					_skillCheckNormalReqs = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "skillCheckNormalReqs", cr2w, this);
				}
				return _skillCheckNormalReqs;
			}
			set
			{
				if (_skillCheckNormalReqs == value)
				{
					return;
				}
				_skillCheckNormalReqs = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("skillCheckIcon")] 
		public inkImageWidgetReference SkillCheckIcon
		{
			get
			{
				if (_skillCheckIcon == null)
				{
					_skillCheckIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "skillCheckIcon", cr2w, this);
				}
				return _skillCheckIcon;
			}
			set
			{
				if (_skillCheckIcon == value)
				{
					return;
				}
				_skillCheckIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("skillCheckText")] 
		public inkTextWidgetReference SkillCheckText
		{
			get
			{
				if (_skillCheckText == null)
				{
					_skillCheckText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "skillCheckText", cr2w, this);
				}
				return _skillCheckText;
			}
			set
			{
				if (_skillCheckText == value)
				{
					return;
				}
				_skillCheckText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("RootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "RootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("inActiveTransparency")] 
		public CFloat InActiveTransparency
		{
			get
			{
				if (_inActiveTransparency == null)
				{
					_inActiveTransparency = (CFloat) CR2WTypeManager.Create("Float", "inActiveTransparency", cr2w, this);
				}
				return _inActiveTransparency;
			}
			set
			{
				if (_inActiveTransparency == value)
				{
					return;
				}
				_inActiveTransparency = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("inputDisplayController")] 
		public wCHandle<inkInputDisplayController> InputDisplayController
		{
			get
			{
				if (_inputDisplayController == null)
				{
					_inputDisplayController = (wCHandle<inkInputDisplayController>) CR2WTypeManager.Create("whandle:inkInputDisplayController", "inputDisplayController", cr2w, this);
				}
				return _inputDisplayController;
			}
			set
			{
				if (_inputDisplayController == value)
				{
					return;
				}
				_inputDisplayController = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		public interactionItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
