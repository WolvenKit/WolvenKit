using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeGridButton : inkToggleController
	{
		private inkImageWidgetReference _frameImg;
		private inkImageWidgetReference _dynamicImg;
		private inkWidgetReference _bgWidget;
		private inkWidgetReference _hoverWidget;
		private inkImageWidgetReference _plusImg;
		private CName _currentImagePart;
		private redResourceReferenceScriptToken _atlasRef;
		private CInt32 _buttonData;
		private CWeakHandle<PhotoModeGridList> _parentGrid;
		private CInt32 _index;
		private CBool _visibleOnGrid;
		private CFloat _imageScalingSpeed;
		private CFloat _opacityScalingSpeed;

		[Ordinal(13)] 
		[RED("FrameImg")] 
		public inkImageWidgetReference FrameImg
		{
			get => GetProperty(ref _frameImg);
			set => SetProperty(ref _frameImg, value);
		}

		[Ordinal(14)] 
		[RED("DynamicImg")] 
		public inkImageWidgetReference DynamicImg
		{
			get => GetProperty(ref _dynamicImg);
			set => SetProperty(ref _dynamicImg, value);
		}

		[Ordinal(15)] 
		[RED("BgWidget")] 
		public inkWidgetReference BgWidget
		{
			get => GetProperty(ref _bgWidget);
			set => SetProperty(ref _bgWidget, value);
		}

		[Ordinal(16)] 
		[RED("HoverWidget")] 
		public inkWidgetReference HoverWidget
		{
			get => GetProperty(ref _hoverWidget);
			set => SetProperty(ref _hoverWidget, value);
		}

		[Ordinal(17)] 
		[RED("PlusImg")] 
		public inkImageWidgetReference PlusImg
		{
			get => GetProperty(ref _plusImg);
			set => SetProperty(ref _plusImg, value);
		}

		[Ordinal(18)] 
		[RED("currentImagePart")] 
		public CName CurrentImagePart
		{
			get => GetProperty(ref _currentImagePart);
			set => SetProperty(ref _currentImagePart, value);
		}

		[Ordinal(19)] 
		[RED("atlasRef")] 
		public redResourceReferenceScriptToken AtlasRef
		{
			get => GetProperty(ref _atlasRef);
			set => SetProperty(ref _atlasRef, value);
		}

		[Ordinal(20)] 
		[RED("buttonData")] 
		public CInt32 ButtonData
		{
			get => GetProperty(ref _buttonData);
			set => SetProperty(ref _buttonData, value);
		}

		[Ordinal(21)] 
		[RED("parentGrid")] 
		public CWeakHandle<PhotoModeGridList> ParentGrid
		{
			get => GetProperty(ref _parentGrid);
			set => SetProperty(ref _parentGrid, value);
		}

		[Ordinal(22)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(23)] 
		[RED("visibleOnGrid")] 
		public CBool VisibleOnGrid
		{
			get => GetProperty(ref _visibleOnGrid);
			set => SetProperty(ref _visibleOnGrid, value);
		}

		[Ordinal(24)] 
		[RED("imageScalingSpeed")] 
		public CFloat ImageScalingSpeed
		{
			get => GetProperty(ref _imageScalingSpeed);
			set => SetProperty(ref _imageScalingSpeed, value);
		}

		[Ordinal(25)] 
		[RED("opacityScalingSpeed")] 
		public CFloat OpacityScalingSpeed
		{
			get => GetProperty(ref _opacityScalingSpeed);
			set => SetProperty(ref _opacityScalingSpeed, value);
		}
	}
}
