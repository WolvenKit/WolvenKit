using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeMenuListItem : inkListItemController
	{
		private inkWidgetReference _scrollBarRef;
		private inkTextWidgetReference _counterLabelRef;
		private inkTextWidgetReference _textLabelRef;
		private inkWidgetReference _optionSelectorRef;
		private inkWidgetReference _leftArrow;
		private inkWidgetReference _rightArrow;
		private inkWidgetReference _leftButton;
		private inkWidgetReference _rightButton;
		private inkTextWidgetReference _optionLabelRef;
		private inkWidgetReference _selectedWidgetRef;
		private inkWidgetReference _textRootWidgetRef;
		private inkWidgetReference _sliderRootWidgetRef;
		private inkWidgetReference _optionSelectorRootWidgetRef;
		private inkWidgetReference _holdButtonRootWidgetRef;
		private inkWidgetReference _scrollBarLineRef;
		private inkWidgetReference _scrollBarHandleRef;
		private inkWidgetReference _scrollSlidingAreaRef;
		private inkWidgetReference _holdProgressRef;
		private wCHandle<inkSliderController> _scrollBar;
		private wCHandle<inkSelectorController> _optionSelector;
		private CArray<gameuiPhotoModeOptionSelectorData> _optionSelectorValues;
		private CFloat _sliderValue;
		private CFloat _stepValue;
		private CBool _sliderShowPercents;
		private wCHandle<gameuiPhotoModeMenuController> _photoModeController;
		private inkMargin _holdBgInitMargin;
		private CBool _allowHold;
		private CInt32 _inputDirection;
		private CFloat _inputStepTime;
		private CFloat _inputHoldTime;
		private CFloat _arrowClickedTime;
		private CBool _isSelected;
		private CHandle<inkanimProxy> _fadeAnim;
		private CFloat _rightArrowInitOpacity;
		private CFloat _leftArrowInitOpacity;
		private CFloat _scrollBarHandleInitOpacity;
		private CFloat _scrollBarLineInitOpacity;

		[Ordinal(16)] 
		[RED("ScrollBarRef")] 
		public inkWidgetReference ScrollBarRef
		{
			get
			{
				if (_scrollBarRef == null)
				{
					_scrollBarRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ScrollBarRef", cr2w, this);
				}
				return _scrollBarRef;
			}
			set
			{
				if (_scrollBarRef == value)
				{
					return;
				}
				_scrollBarRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("CounterLabelRef")] 
		public inkTextWidgetReference CounterLabelRef
		{
			get
			{
				if (_counterLabelRef == null)
				{
					_counterLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "CounterLabelRef", cr2w, this);
				}
				return _counterLabelRef;
			}
			set
			{
				if (_counterLabelRef == value)
				{
					return;
				}
				_counterLabelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("TextLabelRef")] 
		public inkTextWidgetReference TextLabelRef
		{
			get
			{
				if (_textLabelRef == null)
				{
					_textLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "TextLabelRef", cr2w, this);
				}
				return _textLabelRef;
			}
			set
			{
				if (_textLabelRef == value)
				{
					return;
				}
				_textLabelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("OptionSelectorRef")] 
		public inkWidgetReference OptionSelectorRef
		{
			get
			{
				if (_optionSelectorRef == null)
				{
					_optionSelectorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "OptionSelectorRef", cr2w, this);
				}
				return _optionSelectorRef;
			}
			set
			{
				if (_optionSelectorRef == value)
				{
					return;
				}
				_optionSelectorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get
			{
				if (_leftArrow == null)
				{
					_leftArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LeftArrow", cr2w, this);
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

		[Ordinal(21)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get
			{
				if (_rightArrow == null)
				{
					_rightArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "RightArrow", cr2w, this);
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

		[Ordinal(22)] 
		[RED("LeftButton")] 
		public inkWidgetReference LeftButton
		{
			get
			{
				if (_leftButton == null)
				{
					_leftButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LeftButton", cr2w, this);
				}
				return _leftButton;
			}
			set
			{
				if (_leftButton == value)
				{
					return;
				}
				_leftButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("RightButton")] 
		public inkWidgetReference RightButton
		{
			get
			{
				if (_rightButton == null)
				{
					_rightButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "RightButton", cr2w, this);
				}
				return _rightButton;
			}
			set
			{
				if (_rightButton == value)
				{
					return;
				}
				_rightButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("OptionLabelRef")] 
		public inkTextWidgetReference OptionLabelRef
		{
			get
			{
				if (_optionLabelRef == null)
				{
					_optionLabelRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "OptionLabelRef", cr2w, this);
				}
				return _optionLabelRef;
			}
			set
			{
				if (_optionLabelRef == value)
				{
					return;
				}
				_optionLabelRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("SelectedWidgetRef")] 
		public inkWidgetReference SelectedWidgetRef
		{
			get
			{
				if (_selectedWidgetRef == null)
				{
					_selectedWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SelectedWidgetRef", cr2w, this);
				}
				return _selectedWidgetRef;
			}
			set
			{
				if (_selectedWidgetRef == value)
				{
					return;
				}
				_selectedWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("TextRootWidgetRef")] 
		public inkWidgetReference TextRootWidgetRef
		{
			get
			{
				if (_textRootWidgetRef == null)
				{
					_textRootWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TextRootWidgetRef", cr2w, this);
				}
				return _textRootWidgetRef;
			}
			set
			{
				if (_textRootWidgetRef == value)
				{
					return;
				}
				_textRootWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("SliderRootWidgetRef")] 
		public inkWidgetReference SliderRootWidgetRef
		{
			get
			{
				if (_sliderRootWidgetRef == null)
				{
					_sliderRootWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "SliderRootWidgetRef", cr2w, this);
				}
				return _sliderRootWidgetRef;
			}
			set
			{
				if (_sliderRootWidgetRef == value)
				{
					return;
				}
				_sliderRootWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("OptionSelectorRootWidgetRef")] 
		public inkWidgetReference OptionSelectorRootWidgetRef
		{
			get
			{
				if (_optionSelectorRootWidgetRef == null)
				{
					_optionSelectorRootWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "OptionSelectorRootWidgetRef", cr2w, this);
				}
				return _optionSelectorRootWidgetRef;
			}
			set
			{
				if (_optionSelectorRootWidgetRef == value)
				{
					return;
				}
				_optionSelectorRootWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("HoldButtonRootWidgetRef")] 
		public inkWidgetReference HoldButtonRootWidgetRef
		{
			get
			{
				if (_holdButtonRootWidgetRef == null)
				{
					_holdButtonRootWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "HoldButtonRootWidgetRef", cr2w, this);
				}
				return _holdButtonRootWidgetRef;
			}
			set
			{
				if (_holdButtonRootWidgetRef == value)
				{
					return;
				}
				_holdButtonRootWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("ScrollBarLineRef")] 
		public inkWidgetReference ScrollBarLineRef
		{
			get
			{
				if (_scrollBarLineRef == null)
				{
					_scrollBarLineRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ScrollBarLineRef", cr2w, this);
				}
				return _scrollBarLineRef;
			}
			set
			{
				if (_scrollBarLineRef == value)
				{
					return;
				}
				_scrollBarLineRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("ScrollBarHandleRef")] 
		public inkWidgetReference ScrollBarHandleRef
		{
			get
			{
				if (_scrollBarHandleRef == null)
				{
					_scrollBarHandleRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ScrollBarHandleRef", cr2w, this);
				}
				return _scrollBarHandleRef;
			}
			set
			{
				if (_scrollBarHandleRef == value)
				{
					return;
				}
				_scrollBarHandleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("ScrollSlidingAreaRef")] 
		public inkWidgetReference ScrollSlidingAreaRef
		{
			get
			{
				if (_scrollSlidingAreaRef == null)
				{
					_scrollSlidingAreaRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ScrollSlidingAreaRef", cr2w, this);
				}
				return _scrollSlidingAreaRef;
			}
			set
			{
				if (_scrollSlidingAreaRef == value)
				{
					return;
				}
				_scrollSlidingAreaRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("HoldProgressRef")] 
		public inkWidgetReference HoldProgressRef
		{
			get
			{
				if (_holdProgressRef == null)
				{
					_holdProgressRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "HoldProgressRef", cr2w, this);
				}
				return _holdProgressRef;
			}
			set
			{
				if (_holdProgressRef == value)
				{
					return;
				}
				_holdProgressRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("ScrollBar")] 
		public wCHandle<inkSliderController> ScrollBar
		{
			get
			{
				if (_scrollBar == null)
				{
					_scrollBar = (wCHandle<inkSliderController>) CR2WTypeManager.Create("whandle:inkSliderController", "ScrollBar", cr2w, this);
				}
				return _scrollBar;
			}
			set
			{
				if (_scrollBar == value)
				{
					return;
				}
				_scrollBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("OptionSelector")] 
		public wCHandle<inkSelectorController> OptionSelector
		{
			get
			{
				if (_optionSelector == null)
				{
					_optionSelector = (wCHandle<inkSelectorController>) CR2WTypeManager.Create("whandle:inkSelectorController", "OptionSelector", cr2w, this);
				}
				return _optionSelector;
			}
			set
			{
				if (_optionSelector == value)
				{
					return;
				}
				_optionSelector = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("OptionSelectorValues")] 
		public CArray<gameuiPhotoModeOptionSelectorData> OptionSelectorValues
		{
			get
			{
				if (_optionSelectorValues == null)
				{
					_optionSelectorValues = (CArray<gameuiPhotoModeOptionSelectorData>) CR2WTypeManager.Create("array:gameuiPhotoModeOptionSelectorData", "OptionSelectorValues", cr2w, this);
				}
				return _optionSelectorValues;
			}
			set
			{
				if (_optionSelectorValues == value)
				{
					return;
				}
				_optionSelectorValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("SliderValue")] 
		public CFloat SliderValue
		{
			get
			{
				if (_sliderValue == null)
				{
					_sliderValue = (CFloat) CR2WTypeManager.Create("Float", "SliderValue", cr2w, this);
				}
				return _sliderValue;
			}
			set
			{
				if (_sliderValue == value)
				{
					return;
				}
				_sliderValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("StepValue")] 
		public CFloat StepValue
		{
			get
			{
				if (_stepValue == null)
				{
					_stepValue = (CFloat) CR2WTypeManager.Create("Float", "StepValue", cr2w, this);
				}
				return _stepValue;
			}
			set
			{
				if (_stepValue == value)
				{
					return;
				}
				_stepValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("SliderShowPercents")] 
		public CBool SliderShowPercents
		{
			get
			{
				if (_sliderShowPercents == null)
				{
					_sliderShowPercents = (CBool) CR2WTypeManager.Create("Bool", "SliderShowPercents", cr2w, this);
				}
				return _sliderShowPercents;
			}
			set
			{
				if (_sliderShowPercents == value)
				{
					return;
				}
				_sliderShowPercents = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("photoModeController")] 
		public wCHandle<gameuiPhotoModeMenuController> PhotoModeController
		{
			get
			{
				if (_photoModeController == null)
				{
					_photoModeController = (wCHandle<gameuiPhotoModeMenuController>) CR2WTypeManager.Create("whandle:gameuiPhotoModeMenuController", "photoModeController", cr2w, this);
				}
				return _photoModeController;
			}
			set
			{
				if (_photoModeController == value)
				{
					return;
				}
				_photoModeController = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("holdBgInitMargin")] 
		public inkMargin HoldBgInitMargin
		{
			get
			{
				if (_holdBgInitMargin == null)
				{
					_holdBgInitMargin = (inkMargin) CR2WTypeManager.Create("inkMargin", "holdBgInitMargin", cr2w, this);
				}
				return _holdBgInitMargin;
			}
			set
			{
				if (_holdBgInitMargin == value)
				{
					return;
				}
				_holdBgInitMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("allowHold")] 
		public CBool AllowHold
		{
			get
			{
				if (_allowHold == null)
				{
					_allowHold = (CBool) CR2WTypeManager.Create("Bool", "allowHold", cr2w, this);
				}
				return _allowHold;
			}
			set
			{
				if (_allowHold == value)
				{
					return;
				}
				_allowHold = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("inputDirection")] 
		public CInt32 InputDirection
		{
			get
			{
				if (_inputDirection == null)
				{
					_inputDirection = (CInt32) CR2WTypeManager.Create("Int32", "inputDirection", cr2w, this);
				}
				return _inputDirection;
			}
			set
			{
				if (_inputDirection == value)
				{
					return;
				}
				_inputDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("inputStepTime")] 
		public CFloat InputStepTime
		{
			get
			{
				if (_inputStepTime == null)
				{
					_inputStepTime = (CFloat) CR2WTypeManager.Create("Float", "inputStepTime", cr2w, this);
				}
				return _inputStepTime;
			}
			set
			{
				if (_inputStepTime == value)
				{
					return;
				}
				_inputStepTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("inputHoldTime")] 
		public CFloat InputHoldTime
		{
			get
			{
				if (_inputHoldTime == null)
				{
					_inputHoldTime = (CFloat) CR2WTypeManager.Create("Float", "inputHoldTime", cr2w, this);
				}
				return _inputHoldTime;
			}
			set
			{
				if (_inputHoldTime == value)
				{
					return;
				}
				_inputHoldTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("arrowClickedTime")] 
		public CFloat ArrowClickedTime
		{
			get
			{
				if (_arrowClickedTime == null)
				{
					_arrowClickedTime = (CFloat) CR2WTypeManager.Create("Float", "arrowClickedTime", cr2w, this);
				}
				return _arrowClickedTime;
			}
			set
			{
				if (_arrowClickedTime == value)
				{
					return;
				}
				_arrowClickedTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
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

		[Ordinal(48)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get
			{
				if (_fadeAnim == null)
				{
					_fadeAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "fadeAnim", cr2w, this);
				}
				return _fadeAnim;
			}
			set
			{
				if (_fadeAnim == value)
				{
					return;
				}
				_fadeAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("RightArrowInitOpacity")] 
		public CFloat RightArrowInitOpacity
		{
			get
			{
				if (_rightArrowInitOpacity == null)
				{
					_rightArrowInitOpacity = (CFloat) CR2WTypeManager.Create("Float", "RightArrowInitOpacity", cr2w, this);
				}
				return _rightArrowInitOpacity;
			}
			set
			{
				if (_rightArrowInitOpacity == value)
				{
					return;
				}
				_rightArrowInitOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("LeftArrowInitOpacity")] 
		public CFloat LeftArrowInitOpacity
		{
			get
			{
				if (_leftArrowInitOpacity == null)
				{
					_leftArrowInitOpacity = (CFloat) CR2WTypeManager.Create("Float", "LeftArrowInitOpacity", cr2w, this);
				}
				return _leftArrowInitOpacity;
			}
			set
			{
				if (_leftArrowInitOpacity == value)
				{
					return;
				}
				_leftArrowInitOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("ScrollBarHandleInitOpacity")] 
		public CFloat ScrollBarHandleInitOpacity
		{
			get
			{
				if (_scrollBarHandleInitOpacity == null)
				{
					_scrollBarHandleInitOpacity = (CFloat) CR2WTypeManager.Create("Float", "ScrollBarHandleInitOpacity", cr2w, this);
				}
				return _scrollBarHandleInitOpacity;
			}
			set
			{
				if (_scrollBarHandleInitOpacity == value)
				{
					return;
				}
				_scrollBarHandleInitOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("ScrollBarLineInitOpacity")] 
		public CFloat ScrollBarLineInitOpacity
		{
			get
			{
				if (_scrollBarLineInitOpacity == null)
				{
					_scrollBarLineInitOpacity = (CFloat) CR2WTypeManager.Create("Float", "ScrollBarLineInitOpacity", cr2w, this);
				}
				return _scrollBarLineInitOpacity;
			}
			set
			{
				if (_scrollBarLineInitOpacity == value)
				{
					return;
				}
				_scrollBarLineInitOpacity = value;
				PropertySet(this);
			}
		}

		public PhotoModeMenuListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
