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
		private inkWidgetReference _gridRoot;
		private inkWidgetReference _gridTopRow;
		private inkWidgetReference _gridBottomRow;
		private wCHandle<inkSliderController> _scrollBar;
		private wCHandle<inkSelectorController> _optionSelector;
		private CArray<gameuiPhotoModeOptionSelectorData> _optionSelectorValues;
		private wCHandle<PhotoModeGridList> _gridSelector;
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
			get => GetProperty(ref _scrollBarRef);
			set => SetProperty(ref _scrollBarRef, value);
		}

		[Ordinal(17)] 
		[RED("CounterLabelRef")] 
		public inkTextWidgetReference CounterLabelRef
		{
			get => GetProperty(ref _counterLabelRef);
			set => SetProperty(ref _counterLabelRef, value);
		}

		[Ordinal(18)] 
		[RED("TextLabelRef")] 
		public inkTextWidgetReference TextLabelRef
		{
			get => GetProperty(ref _textLabelRef);
			set => SetProperty(ref _textLabelRef, value);
		}

		[Ordinal(19)] 
		[RED("OptionSelectorRef")] 
		public inkWidgetReference OptionSelectorRef
		{
			get => GetProperty(ref _optionSelectorRef);
			set => SetProperty(ref _optionSelectorRef, value);
		}

		[Ordinal(20)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetProperty(ref _leftArrow);
			set => SetProperty(ref _leftArrow, value);
		}

		[Ordinal(21)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetProperty(ref _rightArrow);
			set => SetProperty(ref _rightArrow, value);
		}

		[Ordinal(22)] 
		[RED("LeftButton")] 
		public inkWidgetReference LeftButton
		{
			get => GetProperty(ref _leftButton);
			set => SetProperty(ref _leftButton, value);
		}

		[Ordinal(23)] 
		[RED("RightButton")] 
		public inkWidgetReference RightButton
		{
			get => GetProperty(ref _rightButton);
			set => SetProperty(ref _rightButton, value);
		}

		[Ordinal(24)] 
		[RED("OptionLabelRef")] 
		public inkTextWidgetReference OptionLabelRef
		{
			get => GetProperty(ref _optionLabelRef);
			set => SetProperty(ref _optionLabelRef, value);
		}

		[Ordinal(25)] 
		[RED("SelectedWidgetRef")] 
		public inkWidgetReference SelectedWidgetRef
		{
			get => GetProperty(ref _selectedWidgetRef);
			set => SetProperty(ref _selectedWidgetRef, value);
		}

		[Ordinal(26)] 
		[RED("TextRootWidgetRef")] 
		public inkWidgetReference TextRootWidgetRef
		{
			get => GetProperty(ref _textRootWidgetRef);
			set => SetProperty(ref _textRootWidgetRef, value);
		}

		[Ordinal(27)] 
		[RED("SliderRootWidgetRef")] 
		public inkWidgetReference SliderRootWidgetRef
		{
			get => GetProperty(ref _sliderRootWidgetRef);
			set => SetProperty(ref _sliderRootWidgetRef, value);
		}

		[Ordinal(28)] 
		[RED("OptionSelectorRootWidgetRef")] 
		public inkWidgetReference OptionSelectorRootWidgetRef
		{
			get => GetProperty(ref _optionSelectorRootWidgetRef);
			set => SetProperty(ref _optionSelectorRootWidgetRef, value);
		}

		[Ordinal(29)] 
		[RED("HoldButtonRootWidgetRef")] 
		public inkWidgetReference HoldButtonRootWidgetRef
		{
			get => GetProperty(ref _holdButtonRootWidgetRef);
			set => SetProperty(ref _holdButtonRootWidgetRef, value);
		}

		[Ordinal(30)] 
		[RED("ScrollBarLineRef")] 
		public inkWidgetReference ScrollBarLineRef
		{
			get => GetProperty(ref _scrollBarLineRef);
			set => SetProperty(ref _scrollBarLineRef, value);
		}

		[Ordinal(31)] 
		[RED("ScrollBarHandleRef")] 
		public inkWidgetReference ScrollBarHandleRef
		{
			get => GetProperty(ref _scrollBarHandleRef);
			set => SetProperty(ref _scrollBarHandleRef, value);
		}

		[Ordinal(32)] 
		[RED("ScrollSlidingAreaRef")] 
		public inkWidgetReference ScrollSlidingAreaRef
		{
			get => GetProperty(ref _scrollSlidingAreaRef);
			set => SetProperty(ref _scrollSlidingAreaRef, value);
		}

		[Ordinal(33)] 
		[RED("HoldProgressRef")] 
		public inkWidgetReference HoldProgressRef
		{
			get => GetProperty(ref _holdProgressRef);
			set => SetProperty(ref _holdProgressRef, value);
		}

		[Ordinal(34)] 
		[RED("GridRoot")] 
		public inkWidgetReference GridRoot
		{
			get => GetProperty(ref _gridRoot);
			set => SetProperty(ref _gridRoot, value);
		}

		[Ordinal(35)] 
		[RED("GridTopRow")] 
		public inkWidgetReference GridTopRow
		{
			get => GetProperty(ref _gridTopRow);
			set => SetProperty(ref _gridTopRow, value);
		}

		[Ordinal(36)] 
		[RED("GridBottomRow")] 
		public inkWidgetReference GridBottomRow
		{
			get => GetProperty(ref _gridBottomRow);
			set => SetProperty(ref _gridBottomRow, value);
		}

		[Ordinal(37)] 
		[RED("ScrollBar")] 
		public wCHandle<inkSliderController> ScrollBar
		{
			get => GetProperty(ref _scrollBar);
			set => SetProperty(ref _scrollBar, value);
		}

		[Ordinal(38)] 
		[RED("OptionSelector")] 
		public wCHandle<inkSelectorController> OptionSelector
		{
			get => GetProperty(ref _optionSelector);
			set => SetProperty(ref _optionSelector, value);
		}

		[Ordinal(39)] 
		[RED("OptionSelectorValues")] 
		public CArray<gameuiPhotoModeOptionSelectorData> OptionSelectorValues
		{
			get => GetProperty(ref _optionSelectorValues);
			set => SetProperty(ref _optionSelectorValues, value);
		}

		[Ordinal(40)] 
		[RED("GridSelector")] 
		public wCHandle<PhotoModeGridList> GridSelector
		{
			get => GetProperty(ref _gridSelector);
			set => SetProperty(ref _gridSelector, value);
		}

		[Ordinal(41)] 
		[RED("SliderValue")] 
		public CFloat SliderValue
		{
			get => GetProperty(ref _sliderValue);
			set => SetProperty(ref _sliderValue, value);
		}

		[Ordinal(42)] 
		[RED("StepValue")] 
		public CFloat StepValue
		{
			get => GetProperty(ref _stepValue);
			set => SetProperty(ref _stepValue, value);
		}

		[Ordinal(43)] 
		[RED("SliderShowPercents")] 
		public CBool SliderShowPercents
		{
			get => GetProperty(ref _sliderShowPercents);
			set => SetProperty(ref _sliderShowPercents, value);
		}

		[Ordinal(44)] 
		[RED("photoModeController")] 
		public wCHandle<gameuiPhotoModeMenuController> PhotoModeController
		{
			get => GetProperty(ref _photoModeController);
			set => SetProperty(ref _photoModeController, value);
		}

		[Ordinal(45)] 
		[RED("holdBgInitMargin")] 
		public inkMargin HoldBgInitMargin
		{
			get => GetProperty(ref _holdBgInitMargin);
			set => SetProperty(ref _holdBgInitMargin, value);
		}

		[Ordinal(46)] 
		[RED("allowHold")] 
		public CBool AllowHold
		{
			get => GetProperty(ref _allowHold);
			set => SetProperty(ref _allowHold, value);
		}

		[Ordinal(47)] 
		[RED("inputDirection")] 
		public CInt32 InputDirection
		{
			get => GetProperty(ref _inputDirection);
			set => SetProperty(ref _inputDirection, value);
		}

		[Ordinal(48)] 
		[RED("inputStepTime")] 
		public CFloat InputStepTime
		{
			get => GetProperty(ref _inputStepTime);
			set => SetProperty(ref _inputStepTime, value);
		}

		[Ordinal(49)] 
		[RED("inputHoldTime")] 
		public CFloat InputHoldTime
		{
			get => GetProperty(ref _inputHoldTime);
			set => SetProperty(ref _inputHoldTime, value);
		}

		[Ordinal(50)] 
		[RED("arrowClickedTime")] 
		public CFloat ArrowClickedTime
		{
			get => GetProperty(ref _arrowClickedTime);
			set => SetProperty(ref _arrowClickedTime, value);
		}

		[Ordinal(51)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetProperty(ref _isSelected);
			set => SetProperty(ref _isSelected, value);
		}

		[Ordinal(52)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetProperty(ref _fadeAnim);
			set => SetProperty(ref _fadeAnim, value);
		}

		[Ordinal(53)] 
		[RED("RightArrowInitOpacity")] 
		public CFloat RightArrowInitOpacity
		{
			get => GetProperty(ref _rightArrowInitOpacity);
			set => SetProperty(ref _rightArrowInitOpacity, value);
		}

		[Ordinal(54)] 
		[RED("LeftArrowInitOpacity")] 
		public CFloat LeftArrowInitOpacity
		{
			get => GetProperty(ref _leftArrowInitOpacity);
			set => SetProperty(ref _leftArrowInitOpacity, value);
		}

		[Ordinal(55)] 
		[RED("ScrollBarHandleInitOpacity")] 
		public CFloat ScrollBarHandleInitOpacity
		{
			get => GetProperty(ref _scrollBarHandleInitOpacity);
			set => SetProperty(ref _scrollBarHandleInitOpacity, value);
		}

		[Ordinal(56)] 
		[RED("ScrollBarLineInitOpacity")] 
		public CFloat ScrollBarLineInitOpacity
		{
			get => GetProperty(ref _scrollBarLineInitOpacity);
			set => SetProperty(ref _scrollBarLineInitOpacity, value);
		}

		public PhotoModeMenuListItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
