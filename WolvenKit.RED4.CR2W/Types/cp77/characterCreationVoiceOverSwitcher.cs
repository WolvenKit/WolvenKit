using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationVoiceOverSwitcher : inkWidgetLogicController
	{
		private inkTextWidgetReference _selectedLabel;
		private inkWidgetReference _selectorNextBtn;
		private inkWidgetReference _selectorPrevBtn;
		private inkTextWidgetReference _warningLabel;
		private CBool _isMale;
		private CString _male;
		private CString _female;
		private inkImageWidgetReference _selectorTexture;
		private inkImageWidgetReference _arrowsTexture;
		private inkWidgetReference _optionSwitchHint;
		private CHandle<inkTextReplaceAnimationController> _translationAnimationCtrl;
		private wCHandle<inkWidget> _selector;

		[Ordinal(1)] 
		[RED("selectedLabel")] 
		public inkTextWidgetReference SelectedLabel
		{
			get
			{
				if (_selectedLabel == null)
				{
					_selectedLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "selectedLabel", cr2w, this);
				}
				return _selectedLabel;
			}
			set
			{
				if (_selectedLabel == value)
				{
					return;
				}
				_selectedLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("selectorNextBtn")] 
		public inkWidgetReference SelectorNextBtn
		{
			get
			{
				if (_selectorNextBtn == null)
				{
					_selectorNextBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectorNextBtn", cr2w, this);
				}
				return _selectorNextBtn;
			}
			set
			{
				if (_selectorNextBtn == value)
				{
					return;
				}
				_selectorNextBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("selectorPrevBtn")] 
		public inkWidgetReference SelectorPrevBtn
		{
			get
			{
				if (_selectorPrevBtn == null)
				{
					_selectorPrevBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectorPrevBtn", cr2w, this);
				}
				return _selectorPrevBtn;
			}
			set
			{
				if (_selectorPrevBtn == value)
				{
					return;
				}
				_selectorPrevBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("warningLabel")] 
		public inkTextWidgetReference WarningLabel
		{
			get
			{
				if (_warningLabel == null)
				{
					_warningLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "warningLabel", cr2w, this);
				}
				return _warningLabel;
			}
			set
			{
				if (_warningLabel == value)
				{
					return;
				}
				_warningLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isMale")] 
		public CBool IsMale
		{
			get
			{
				if (_isMale == null)
				{
					_isMale = (CBool) CR2WTypeManager.Create("Bool", "isMale", cr2w, this);
				}
				return _isMale;
			}
			set
			{
				if (_isMale == value)
				{
					return;
				}
				_isMale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("male")] 
		public CString Male
		{
			get
			{
				if (_male == null)
				{
					_male = (CString) CR2WTypeManager.Create("String", "male", cr2w, this);
				}
				return _male;
			}
			set
			{
				if (_male == value)
				{
					return;
				}
				_male = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("female")] 
		public CString Female
		{
			get
			{
				if (_female == null)
				{
					_female = (CString) CR2WTypeManager.Create("String", "female", cr2w, this);
				}
				return _female;
			}
			set
			{
				if (_female == value)
				{
					return;
				}
				_female = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("selectorTexture")] 
		public inkImageWidgetReference SelectorTexture
		{
			get
			{
				if (_selectorTexture == null)
				{
					_selectorTexture = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "selectorTexture", cr2w, this);
				}
				return _selectorTexture;
			}
			set
			{
				if (_selectorTexture == value)
				{
					return;
				}
				_selectorTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("arrowsTexture")] 
		public inkImageWidgetReference ArrowsTexture
		{
			get
			{
				if (_arrowsTexture == null)
				{
					_arrowsTexture = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrowsTexture", cr2w, this);
				}
				return _arrowsTexture;
			}
			set
			{
				if (_arrowsTexture == value)
				{
					return;
				}
				_arrowsTexture = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("translationAnimationCtrl")] 
		public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl
		{
			get
			{
				if (_translationAnimationCtrl == null)
				{
					_translationAnimationCtrl = (CHandle<inkTextReplaceAnimationController>) CR2WTypeManager.Create("handle:inkTextReplaceAnimationController", "translationAnimationCtrl", cr2w, this);
				}
				return _translationAnimationCtrl;
			}
			set
			{
				if (_translationAnimationCtrl == value)
				{
					return;
				}
				_translationAnimationCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("selector")] 
		public wCHandle<inkWidget> Selector
		{
			get
			{
				if (_selector == null)
				{
					_selector = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "selector", cr2w, this);
				}
				return _selector;
			}
			set
			{
				if (_selector == value)
				{
					return;
				}
				_selector = value;
				PropertySet(this);
			}
		}

		public characterCreationVoiceOverSwitcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
