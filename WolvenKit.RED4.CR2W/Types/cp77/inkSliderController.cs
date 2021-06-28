using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSliderController : inkWidgetLogicController
	{
		private inkWidgetReference _slidingAreaRef;
		private inkWidgetReference _handleRef;
		private inkWidgetReference _nextRef;
		private inkWidgetReference _priorRef;
		private CEnum<inkESliderDirection> _direction;
		private CBool _autoSizeHandle;
		private CFloat _minHandleSize;
		private CFloat _maxHandleSize;
		private CFloat _percentHandleSize;
		private CFloat _currentProgress;
		private CFloat _minimumValue;
		private CFloat _maximumValue;
		private CFloat _step;
		private inkSliderControllerInputCallback _sliderInput;
		private inkSliderControllerValueChangeCallback _sliderValueChanged;
		private inkSliderControllerHandleReleasedCallback _sliderHandleReleased;

		[Ordinal(1)] 
		[RED("slidingAreaRef")] 
		public inkWidgetReference SlidingAreaRef
		{
			get => GetProperty(ref _slidingAreaRef);
			set => SetProperty(ref _slidingAreaRef, value);
		}

		[Ordinal(2)] 
		[RED("handleRef")] 
		public inkWidgetReference HandleRef
		{
			get => GetProperty(ref _handleRef);
			set => SetProperty(ref _handleRef, value);
		}

		[Ordinal(3)] 
		[RED("nextRef")] 
		public inkWidgetReference NextRef
		{
			get => GetProperty(ref _nextRef);
			set => SetProperty(ref _nextRef, value);
		}

		[Ordinal(4)] 
		[RED("priorRef")] 
		public inkWidgetReference PriorRef
		{
			get => GetProperty(ref _priorRef);
			set => SetProperty(ref _priorRef, value);
		}

		[Ordinal(5)] 
		[RED("direction")] 
		public CEnum<inkESliderDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(6)] 
		[RED("autoSizeHandle")] 
		public CBool AutoSizeHandle
		{
			get => GetProperty(ref _autoSizeHandle);
			set => SetProperty(ref _autoSizeHandle, value);
		}

		[Ordinal(7)] 
		[RED("minHandleSize")] 
		public CFloat MinHandleSize
		{
			get => GetProperty(ref _minHandleSize);
			set => SetProperty(ref _minHandleSize, value);
		}

		[Ordinal(8)] 
		[RED("maxHandleSize")] 
		public CFloat MaxHandleSize
		{
			get => GetProperty(ref _maxHandleSize);
			set => SetProperty(ref _maxHandleSize, value);
		}

		[Ordinal(9)] 
		[RED("percentHandleSize")] 
		public CFloat PercentHandleSize
		{
			get => GetProperty(ref _percentHandleSize);
			set => SetProperty(ref _percentHandleSize, value);
		}

		[Ordinal(10)] 
		[RED("currentProgress")] 
		public CFloat CurrentProgress
		{
			get => GetProperty(ref _currentProgress);
			set => SetProperty(ref _currentProgress, value);
		}

		[Ordinal(11)] 
		[RED("minimumValue")] 
		public CFloat MinimumValue
		{
			get => GetProperty(ref _minimumValue);
			set => SetProperty(ref _minimumValue, value);
		}

		[Ordinal(12)] 
		[RED("maximumValue")] 
		public CFloat MaximumValue
		{
			get => GetProperty(ref _maximumValue);
			set => SetProperty(ref _maximumValue, value);
		}

		[Ordinal(13)] 
		[RED("step")] 
		public CFloat Step
		{
			get => GetProperty(ref _step);
			set => SetProperty(ref _step, value);
		}

		[Ordinal(14)] 
		[RED("SliderInput")] 
		public inkSliderControllerInputCallback SliderInput
		{
			get => GetProperty(ref _sliderInput);
			set => SetProperty(ref _sliderInput, value);
		}

		[Ordinal(15)] 
		[RED("SliderValueChanged")] 
		public inkSliderControllerValueChangeCallback SliderValueChanged
		{
			get => GetProperty(ref _sliderValueChanged);
			set => SetProperty(ref _sliderValueChanged, value);
		}

		[Ordinal(16)] 
		[RED("SliderHandleReleased")] 
		public inkSliderControllerHandleReleasedCallback SliderHandleReleased
		{
			get => GetProperty(ref _sliderHandleReleased);
			set => SetProperty(ref _sliderHandleReleased, value);
		}

		public inkSliderController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
