using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeMenuListItem : inkListItemController
	{
		[Ordinal(19)] 
		[RED("ScrollBarRef")] 
		public inkWidgetReference ScrollBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("CounterLabelRef")] 
		public inkTextWidgetReference CounterLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("TextLabelRef")] 
		public inkTextWidgetReference TextLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("OptionSelectorRef")] 
		public inkWidgetReference OptionSelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("LeftButton")] 
		public inkWidgetReference LeftButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("RightButton")] 
		public inkWidgetReference RightButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("OptionLabelRef")] 
		public inkTextWidgetReference OptionLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("SelectedWidgetRef")] 
		public inkWidgetReference SelectedWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("TextRootWidgetRef")] 
		public inkWidgetReference TextRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("SliderRootWidgetRef")] 
		public inkWidgetReference SliderRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("OptionSelectorRootWidgetRef")] 
		public inkWidgetReference OptionSelectorRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("HoldButtonRootWidgetRef")] 
		public inkWidgetReference HoldButtonRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("ScrollBarLineRef")] 
		public inkWidgetReference ScrollBarLineRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("ScrollBarHandleRef")] 
		public inkWidgetReference ScrollBarHandleRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("ScrollSlidingAreaRef")] 
		public inkWidgetReference ScrollSlidingAreaRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("HoldProgressRef")] 
		public inkWidgetReference HoldProgressRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("GridRoot")] 
		public inkWidgetReference GridRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("GridTopRow")] 
		public inkWidgetReference GridTopRow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("GridBottomRow")] 
		public inkWidgetReference GridBottomRow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("ScrollBar")] 
		public CWeakHandle<inkSliderController> ScrollBar
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(41)] 
		[RED("OptionSelector")] 
		public CWeakHandle<inkSelectorController> OptionSelector
		{
			get => GetPropertyValue<CWeakHandle<inkSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSelectorController>>(value);
		}

		[Ordinal(42)] 
		[RED("OptionSelectorValues")] 
		public CArray<gameuiPhotoModeOptionSelectorData> OptionSelectorValues
		{
			get => GetPropertyValue<CArray<gameuiPhotoModeOptionSelectorData>>();
			set => SetPropertyValue<CArray<gameuiPhotoModeOptionSelectorData>>(value);
		}

		[Ordinal(43)] 
		[RED("GridSelector")] 
		public CWeakHandle<PhotoModeGridList> GridSelector
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeGridList>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeGridList>>(value);
		}

		[Ordinal(44)] 
		[RED("SliderValue")] 
		public CFloat SliderValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("StepValue")] 
		public CFloat StepValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(46)] 
		[RED("SliderShowPercents")] 
		public CBool SliderShowPercents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("photoModeController")] 
		public CWeakHandle<gameuiPhotoModeMenuController> PhotoModeController
		{
			get => GetPropertyValue<CWeakHandle<gameuiPhotoModeMenuController>>();
			set => SetPropertyValue<CWeakHandle<gameuiPhotoModeMenuController>>(value);
		}

		[Ordinal(48)] 
		[RED("doApply")] 
		public CBool DoApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(49)] 
		[RED("holdBgInitMargin")] 
		public inkMargin HoldBgInitMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(50)] 
		[RED("allowHold")] 
		public CBool AllowHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(51)] 
		[RED("inputDirection")] 
		public CInt32 InputDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(52)] 
		[RED("inputStepTime")] 
		public CFloat InputStepTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(53)] 
		[RED("inputHoldTime")] 
		public CFloat InputHoldTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("arrowClickedTime")] 
		public CFloat ArrowClickedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(56)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(57)] 
		[RED("RightArrowInitOpacity")] 
		public CFloat RightArrowInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("LeftArrowInitOpacity")] 
		public CFloat LeftArrowInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(59)] 
		[RED("ScrollBarHandleInitOpacity")] 
		public CFloat ScrollBarHandleInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("ScrollBarLineInitOpacity")] 
		public CFloat ScrollBarLineInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PhotoModeMenuListItem()
		{
			ScrollBarRef = new inkWidgetReference();
			CounterLabelRef = new inkTextWidgetReference();
			TextLabelRef = new inkTextWidgetReference();
			OptionSelectorRef = new inkWidgetReference();
			LeftArrow = new inkWidgetReference();
			RightArrow = new inkWidgetReference();
			LeftButton = new inkWidgetReference();
			RightButton = new inkWidgetReference();
			OptionLabelRef = new inkTextWidgetReference();
			SelectedWidgetRef = new inkWidgetReference();
			TextRootWidgetRef = new inkWidgetReference();
			SliderRootWidgetRef = new inkWidgetReference();
			OptionSelectorRootWidgetRef = new inkWidgetReference();
			HoldButtonRootWidgetRef = new inkWidgetReference();
			ScrollBarLineRef = new inkWidgetReference();
			ScrollBarHandleRef = new inkWidgetReference();
			ScrollSlidingAreaRef = new inkWidgetReference();
			HoldProgressRef = new inkWidgetReference();
			GridRoot = new inkWidgetReference();
			GridTopRow = new inkWidgetReference();
			GridBottomRow = new inkWidgetReference();
			OptionSelectorValues = new();
			HoldBgInitMargin = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
