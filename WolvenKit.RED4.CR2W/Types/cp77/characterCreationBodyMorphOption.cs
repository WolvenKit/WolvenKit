using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOption : inkWidgetLogicController
	{
		private inkTextWidgetReference _optionLabel;
		private inkTextWidgetReference _selectedLabel;
		private inkWidgetReference _selectorNextBtn;
		private inkWidgetReference _selectorPrevBtn;
		private inkImageWidgetReference _selectorTexture;
		private inkImageWidgetReference _arrowsTexture;
		private inkWidgetReference _optionSwitchHint;
		private wCHandle<gameuiCharacterCustomizationOption> _selectorOption;
		private wCHandle<gameuiMorphInfo> _morphInfo;
		private wCHandle<gameuiAppearanceInfo> _appearanceInfo;
		private wCHandle<gameuiSwitcherInfo> _switcherInfo;
		private CInt32 _currSelectorIndex;
		private wCHandle<inkWidget> _selector;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(1)] 
		[RED("optionLabel")] 
		public inkTextWidgetReference OptionLabel
		{
			get
			{
				if (_optionLabel == null)
				{
					_optionLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "optionLabel", cr2w, this);
				}
				return _optionLabel;
			}
			set
			{
				if (_optionLabel == value)
				{
					return;
				}
				_optionLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("selectorOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> SelectorOption
		{
			get
			{
				if (_selectorOption == null)
				{
					_selectorOption = (wCHandle<gameuiCharacterCustomizationOption>) CR2WTypeManager.Create("whandle:gameuiCharacterCustomizationOption", "selectorOption", cr2w, this);
				}
				return _selectorOption;
			}
			set
			{
				if (_selectorOption == value)
				{
					return;
				}
				_selectorOption = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("morphInfo")] 
		public wCHandle<gameuiMorphInfo> MorphInfo
		{
			get
			{
				if (_morphInfo == null)
				{
					_morphInfo = (wCHandle<gameuiMorphInfo>) CR2WTypeManager.Create("whandle:gameuiMorphInfo", "morphInfo", cr2w, this);
				}
				return _morphInfo;
			}
			set
			{
				if (_morphInfo == value)
				{
					return;
				}
				_morphInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("appearanceInfo")] 
		public wCHandle<gameuiAppearanceInfo> AppearanceInfo
		{
			get
			{
				if (_appearanceInfo == null)
				{
					_appearanceInfo = (wCHandle<gameuiAppearanceInfo>) CR2WTypeManager.Create("whandle:gameuiAppearanceInfo", "appearanceInfo", cr2w, this);
				}
				return _appearanceInfo;
			}
			set
			{
				if (_appearanceInfo == value)
				{
					return;
				}
				_appearanceInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("switcherInfo")] 
		public wCHandle<gameuiSwitcherInfo> SwitcherInfo
		{
			get
			{
				if (_switcherInfo == null)
				{
					_switcherInfo = (wCHandle<gameuiSwitcherInfo>) CR2WTypeManager.Create("whandle:gameuiSwitcherInfo", "switcherInfo", cr2w, this);
				}
				return _switcherInfo;
			}
			set
			{
				if (_switcherInfo == value)
				{
					return;
				}
				_switcherInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("currSelectorIndex")] 
		public CInt32 CurrSelectorIndex
		{
			get
			{
				if (_currSelectorIndex == null)
				{
					_currSelectorIndex = (CInt32) CR2WTypeManager.Create("Int32", "currSelectorIndex", cr2w, this);
				}
				return _currSelectorIndex;
			}
			set
			{
				if (_currSelectorIndex == value)
				{
					return;
				}
				_currSelectorIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		public characterCreationBodyMorphOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
