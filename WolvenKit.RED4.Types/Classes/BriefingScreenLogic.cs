using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BriefingScreenLogic : inkWidgetLogicController
	{
		private Vector2 _lastSizeSet;
		private CBool _isBriefingVisible;
		private CWeakHandle<gameJournalEntry> _briefingToOpen;
		private inkVideoWidgetReference _videoWidget;
		private inkWidgetReference _mapWidget;
		private inkWidgetReference _paperdollWidget;
		private inkWidgetReference _animatedWidget;
		private CFloat _fadeDuration;
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private Vector2 _minimizedSize;
		private Vector2 _maximizedSize;

		[Ordinal(1)] 
		[RED("lastSizeSet")] 
		public Vector2 LastSizeSet
		{
			get => GetProperty(ref _lastSizeSet);
			set => SetProperty(ref _lastSizeSet, value);
		}

		[Ordinal(2)] 
		[RED("isBriefingVisible")] 
		public CBool IsBriefingVisible
		{
			get => GetProperty(ref _isBriefingVisible);
			set => SetProperty(ref _isBriefingVisible, value);
		}

		[Ordinal(3)] 
		[RED("briefingToOpen")] 
		public CWeakHandle<gameJournalEntry> BriefingToOpen
		{
			get => GetProperty(ref _briefingToOpen);
			set => SetProperty(ref _briefingToOpen, value);
		}

		[Ordinal(4)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(5)] 
		[RED("mapWidget")] 
		public inkWidgetReference MapWidget
		{
			get => GetProperty(ref _mapWidget);
			set => SetProperty(ref _mapWidget, value);
		}

		[Ordinal(6)] 
		[RED("paperdollWidget")] 
		public inkWidgetReference PaperdollWidget
		{
			get => GetProperty(ref _paperdollWidget);
			set => SetProperty(ref _paperdollWidget, value);
		}

		[Ordinal(7)] 
		[RED("animatedWidget")] 
		public inkWidgetReference AnimatedWidget
		{
			get => GetProperty(ref _animatedWidget);
			set => SetProperty(ref _animatedWidget, value);
		}

		[Ordinal(8)] 
		[RED("fadeDuration")] 
		public CFloat FadeDuration
		{
			get => GetProperty(ref _fadeDuration);
			set => SetProperty(ref _fadeDuration, value);
		}

		[Ordinal(9)] 
		[RED("InterpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(10)] 
		[RED("InterpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetProperty(ref _interpolationMode);
			set => SetProperty(ref _interpolationMode, value);
		}

		[Ordinal(11)] 
		[RED("minimizedSize")] 
		public Vector2 MinimizedSize
		{
			get => GetProperty(ref _minimizedSize);
			set => SetProperty(ref _minimizedSize, value);
		}

		[Ordinal(12)] 
		[RED("maximizedSize")] 
		public Vector2 MaximizedSize
		{
			get => GetProperty(ref _maximizedSize);
			set => SetProperty(ref _maximizedSize, value);
		}
	}
}
