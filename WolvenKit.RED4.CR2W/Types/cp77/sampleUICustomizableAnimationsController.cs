using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUICustomizableAnimationsController : inkWidgetLogicController
	{
		private CName _imagePath;
		private CEnum<inkanimInterpolationType> _interpolationType;
		private CEnum<inkanimInterpolationMode> _interpolationMode;
		private CFloat _delayTime;
		private CHandle<inkanimDefinition> _rotation_anim;
		private CHandle<inkanimDefinition> _size_anim;
		private CHandle<inkanimDefinition> _color_anim;
		private CHandle<inkanimDefinition> _alpha_anim;
		private CHandle<inkanimDefinition> _position_anim;
		private wCHandle<inkWidget> _imageWidget;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _canRotate;
		private CBool _canResize;
		private CBool _canChangeColor;
		private CBool _canChangeAlpha;
		private CBool _canMove;
		private Vector2 _defaultSize;
		private inkMargin _defaultMargin;
		private CFloat _defaultRotation;
		private HDRColor _defaultColor;
		private CFloat _defaultAlpha;
		private CBool _isHighlighted;
		private wCHandle<inkWidget> _currentTarget;
		private CHandle<inkanimProxy> _currentAnimProxy;

		[Ordinal(1)] 
		[RED("imagePath")] 
		public CName ImagePath
		{
			get => GetProperty(ref _imagePath);
			set => SetProperty(ref _imagePath, value);
		}

		[Ordinal(2)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(3)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetProperty(ref _interpolationMode);
			set => SetProperty(ref _interpolationMode, value);
		}

		[Ordinal(4)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetProperty(ref _delayTime);
			set => SetProperty(ref _delayTime, value);
		}

		[Ordinal(5)] 
		[RED("rotation_anim")] 
		public CHandle<inkanimDefinition> Rotation_anim
		{
			get => GetProperty(ref _rotation_anim);
			set => SetProperty(ref _rotation_anim, value);
		}

		[Ordinal(6)] 
		[RED("size_anim")] 
		public CHandle<inkanimDefinition> Size_anim
		{
			get => GetProperty(ref _size_anim);
			set => SetProperty(ref _size_anim, value);
		}

		[Ordinal(7)] 
		[RED("color_anim")] 
		public CHandle<inkanimDefinition> Color_anim
		{
			get => GetProperty(ref _color_anim);
			set => SetProperty(ref _color_anim, value);
		}

		[Ordinal(8)] 
		[RED("alpha_anim")] 
		public CHandle<inkanimDefinition> Alpha_anim
		{
			get => GetProperty(ref _alpha_anim);
			set => SetProperty(ref _alpha_anim, value);
		}

		[Ordinal(9)] 
		[RED("position_anim")] 
		public CHandle<inkanimDefinition> Position_anim
		{
			get => GetProperty(ref _position_anim);
			set => SetProperty(ref _position_anim, value);
		}

		[Ordinal(10)] 
		[RED("imageWidget")] 
		public wCHandle<inkWidget> ImageWidget
		{
			get => GetProperty(ref _imageWidget);
			set => SetProperty(ref _imageWidget, value);
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(12)] 
		[RED("CanRotate")] 
		public CBool CanRotate
		{
			get => GetProperty(ref _canRotate);
			set => SetProperty(ref _canRotate, value);
		}

		[Ordinal(13)] 
		[RED("CanResize")] 
		public CBool CanResize
		{
			get => GetProperty(ref _canResize);
			set => SetProperty(ref _canResize, value);
		}

		[Ordinal(14)] 
		[RED("CanChangeColor")] 
		public CBool CanChangeColor
		{
			get => GetProperty(ref _canChangeColor);
			set => SetProperty(ref _canChangeColor, value);
		}

		[Ordinal(15)] 
		[RED("CanChangeAlpha")] 
		public CBool CanChangeAlpha
		{
			get => GetProperty(ref _canChangeAlpha);
			set => SetProperty(ref _canChangeAlpha, value);
		}

		[Ordinal(16)] 
		[RED("CanMove")] 
		public CBool CanMove
		{
			get => GetProperty(ref _canMove);
			set => SetProperty(ref _canMove, value);
		}

		[Ordinal(17)] 
		[RED("defaultSize")] 
		public Vector2 DefaultSize
		{
			get => GetProperty(ref _defaultSize);
			set => SetProperty(ref _defaultSize, value);
		}

		[Ordinal(18)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get => GetProperty(ref _defaultMargin);
			set => SetProperty(ref _defaultMargin, value);
		}

		[Ordinal(19)] 
		[RED("defaultRotation")] 
		public CFloat DefaultRotation
		{
			get => GetProperty(ref _defaultRotation);
			set => SetProperty(ref _defaultRotation, value);
		}

		[Ordinal(20)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		[Ordinal(21)] 
		[RED("defaultAlpha")] 
		public CFloat DefaultAlpha
		{
			get => GetProperty(ref _defaultAlpha);
			set => SetProperty(ref _defaultAlpha, value);
		}

		[Ordinal(22)] 
		[RED("isHighlighted")] 
		public CBool IsHighlighted
		{
			get => GetProperty(ref _isHighlighted);
			set => SetProperty(ref _isHighlighted, value);
		}

		[Ordinal(23)] 
		[RED("currentTarget")] 
		public wCHandle<inkWidget> CurrentTarget
		{
			get => GetProperty(ref _currentTarget);
			set => SetProperty(ref _currentTarget, value);
		}

		[Ordinal(24)] 
		[RED("currentAnimProxy")] 
		public CHandle<inkanimProxy> CurrentAnimProxy
		{
			get => GetProperty(ref _currentAnimProxy);
			set => SetProperty(ref _currentAnimProxy, value);
		}

		public sampleUICustomizableAnimationsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
