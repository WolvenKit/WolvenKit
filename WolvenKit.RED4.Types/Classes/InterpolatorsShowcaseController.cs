using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InterpolatorsShowcaseController : inkWidgetLogicController
	{
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private CWeakHandle<inkWidget> _overlay;
		private CWeakHandle<inkWidget> _heightBar;
		private CWeakHandle<inkWidget> _widthBar;
		private CWeakHandle<inkWidget> _graphPointer;
		private CWeakHandle<inkTextWidget> _counterText;
		private CWeakHandle<inkWidget> _sizeWidget;
		private CWeakHandle<inkWidget> _rotationWidget;
		private CWeakHandle<inkWidget> _marginWidget;
		private CWeakHandle<inkWidget> _colorWidget;
		private CHandle<inkanimDefinition> _sizeAnim;
		private CHandle<inkanimDefinition> _rotationAnim;
		private CHandle<inkanimDefinition> _marginAnim;
		private CHandle<inkanimDefinition> _colorAnim;
		private CHandle<inkanimDefinition> _followTimelineAnim;
		private CHandle<inkanimDefinition> _interpolateAnim;
		private inkMargin _startMargin;
		private CFloat _animLength;
		private CHandle<AnimationsConstructor> _animConstructor;

		[Ordinal(1)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(2)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetProperty(ref _interpolationMode);
			set => SetProperty(ref _interpolationMode, value);
		}

		[Ordinal(3)] 
		[RED("overlay")] 
		public CWeakHandle<inkWidget> Overlay
		{
			get => GetProperty(ref _overlay);
			set => SetProperty(ref _overlay, value);
		}

		[Ordinal(4)] 
		[RED("heightBar")] 
		public CWeakHandle<inkWidget> HeightBar
		{
			get => GetProperty(ref _heightBar);
			set => SetProperty(ref _heightBar, value);
		}

		[Ordinal(5)] 
		[RED("widthBar")] 
		public CWeakHandle<inkWidget> WidthBar
		{
			get => GetProperty(ref _widthBar);
			set => SetProperty(ref _widthBar, value);
		}

		[Ordinal(6)] 
		[RED("graphPointer")] 
		public CWeakHandle<inkWidget> GraphPointer
		{
			get => GetProperty(ref _graphPointer);
			set => SetProperty(ref _graphPointer, value);
		}

		[Ordinal(7)] 
		[RED("counterText")] 
		public CWeakHandle<inkTextWidget> CounterText
		{
			get => GetProperty(ref _counterText);
			set => SetProperty(ref _counterText, value);
		}

		[Ordinal(8)] 
		[RED("sizeWidget")] 
		public CWeakHandle<inkWidget> SizeWidget
		{
			get => GetProperty(ref _sizeWidget);
			set => SetProperty(ref _sizeWidget, value);
		}

		[Ordinal(9)] 
		[RED("rotationWidget")] 
		public CWeakHandle<inkWidget> RotationWidget
		{
			get => GetProperty(ref _rotationWidget);
			set => SetProperty(ref _rotationWidget, value);
		}

		[Ordinal(10)] 
		[RED("marginWidget")] 
		public CWeakHandle<inkWidget> MarginWidget
		{
			get => GetProperty(ref _marginWidget);
			set => SetProperty(ref _marginWidget, value);
		}

		[Ordinal(11)] 
		[RED("colorWidget")] 
		public CWeakHandle<inkWidget> ColorWidget
		{
			get => GetProperty(ref _colorWidget);
			set => SetProperty(ref _colorWidget, value);
		}

		[Ordinal(12)] 
		[RED("sizeAnim")] 
		public CHandle<inkanimDefinition> SizeAnim
		{
			get => GetProperty(ref _sizeAnim);
			set => SetProperty(ref _sizeAnim, value);
		}

		[Ordinal(13)] 
		[RED("rotationAnim")] 
		public CHandle<inkanimDefinition> RotationAnim
		{
			get => GetProperty(ref _rotationAnim);
			set => SetProperty(ref _rotationAnim, value);
		}

		[Ordinal(14)] 
		[RED("marginAnim")] 
		public CHandle<inkanimDefinition> MarginAnim
		{
			get => GetProperty(ref _marginAnim);
			set => SetProperty(ref _marginAnim, value);
		}

		[Ordinal(15)] 
		[RED("colorAnim")] 
		public CHandle<inkanimDefinition> ColorAnim
		{
			get => GetProperty(ref _colorAnim);
			set => SetProperty(ref _colorAnim, value);
		}

		[Ordinal(16)] 
		[RED("followTimelineAnim")] 
		public CHandle<inkanimDefinition> FollowTimelineAnim
		{
			get => GetProperty(ref _followTimelineAnim);
			set => SetProperty(ref _followTimelineAnim, value);
		}

		[Ordinal(17)] 
		[RED("interpolateAnim")] 
		public CHandle<inkanimDefinition> InterpolateAnim
		{
			get => GetProperty(ref _interpolateAnim);
			set => SetProperty(ref _interpolateAnim, value);
		}

		[Ordinal(18)] 
		[RED("startMargin")] 
		public inkMargin StartMargin
		{
			get => GetProperty(ref _startMargin);
			set => SetProperty(ref _startMargin, value);
		}

		[Ordinal(19)] 
		[RED("animLength")] 
		public CFloat AnimLength
		{
			get => GetProperty(ref _animLength);
			set => SetProperty(ref _animLength, value);
		}

		[Ordinal(20)] 
		[RED("animConstructor")] 
		public CHandle<AnimationsConstructor> AnimConstructor
		{
			get => GetProperty(ref _animConstructor);
			set => SetProperty(ref _animConstructor, value);
		}
	}
}
