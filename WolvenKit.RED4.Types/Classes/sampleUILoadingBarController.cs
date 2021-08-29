using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleUILoadingBarController : inkWidgetLogicController
	{
		private Vector2 _minSize;
		private Vector2 _maxSize;
		private CName _imageWidgetPath;
		private CName _textWidgetPath;
		private Vector2 _currentSize;
		private CWeakHandle<inkImageWidget> _imageWidget;
		private CWeakHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("minSize")] 
		public Vector2 MinSize
		{
			get => GetProperty(ref _minSize);
			set => SetProperty(ref _minSize, value);
		}

		[Ordinal(2)] 
		[RED("maxSize")] 
		public Vector2 MaxSize
		{
			get => GetProperty(ref _maxSize);
			set => SetProperty(ref _maxSize, value);
		}

		[Ordinal(3)] 
		[RED("imageWidgetPath")] 
		public CName ImageWidgetPath
		{
			get => GetProperty(ref _imageWidgetPath);
			set => SetProperty(ref _imageWidgetPath, value);
		}

		[Ordinal(4)] 
		[RED("textWidgetPath")] 
		public CName TextWidgetPath
		{
			get => GetProperty(ref _textWidgetPath);
			set => SetProperty(ref _textWidgetPath, value);
		}

		[Ordinal(5)] 
		[RED("currentSize")] 
		public Vector2 CurrentSize
		{
			get => GetProperty(ref _currentSize);
			set => SetProperty(ref _currentSize, value);
		}

		[Ordinal(6)] 
		[RED("imageWidget")] 
		public CWeakHandle<inkImageWidget> ImageWidget
		{
			get => GetProperty(ref _imageWidget);
			set => SetProperty(ref _imageWidget, value);
		}

		[Ordinal(7)] 
		[RED("textWidget")] 
		public CWeakHandle<inkTextWidget> TextWidget
		{
			get => GetProperty(ref _textWidget);
			set => SetProperty(ref _textWidget, value);
		}
	}
}
