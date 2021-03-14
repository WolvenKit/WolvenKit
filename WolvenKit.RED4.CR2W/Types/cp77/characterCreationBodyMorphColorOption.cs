using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphColorOption : inkWidgetLogicController
	{
		private inkTextWidgetReference _optionLabel;
		private inkWidgetReference _colorPickerBtn;
		private inkWidgetReference _selectorNextBtn;
		private inkWidgetReference _selectorPrevBtn;
		private inkImageWidgetReference _selectorTexture;
		private inkImageWidgetReference _arrowsTexture;
		private inkWidgetReference _optionSwitchHint;
		private wCHandle<gameuiCharacterCustomizationOption> _colorPickerOption;
		private wCHandle<gameuiAppearanceInfo> _appearanceInfo;
		private CInt32 _currColorIndex;
		private wCHandle<inkWidget> _selector;

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
		[RED("colorPickerBtn")] 
		public inkWidgetReference ColorPickerBtn
		{
			get
			{
				if (_colorPickerBtn == null)
				{
					_colorPickerBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "colorPickerBtn", cr2w, this);
				}
				return _colorPickerBtn;
			}
			set
			{
				if (_colorPickerBtn == value)
				{
					return;
				}
				_colorPickerBtn = value;
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
		[RED("colorPickerOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> ColorPickerOption
		{
			get
			{
				if (_colorPickerOption == null)
				{
					_colorPickerOption = (wCHandle<gameuiCharacterCustomizationOption>) CR2WTypeManager.Create("whandle:gameuiCharacterCustomizationOption", "colorPickerOption", cr2w, this);
				}
				return _colorPickerOption;
			}
			set
			{
				if (_colorPickerOption == value)
				{
					return;
				}
				_colorPickerOption = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("currColorIndex")] 
		public CInt32 CurrColorIndex
		{
			get
			{
				if (_currColorIndex == null)
				{
					_currColorIndex = (CInt32) CR2WTypeManager.Create("Int32", "currColorIndex", cr2w, this);
				}
				return _currColorIndex;
			}
			set
			{
				if (_currColorIndex == value)
				{
					return;
				}
				_currColorIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		public characterCreationBodyMorphColorOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
