using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleUICustomizableAnimationsController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("imagePath")] 
		public CName ImagePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationType>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationType>>(value);
		}

		[Ordinal(3)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationMode>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationMode>>(value);
		}

		[Ordinal(4)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("rotation_anim")] 
		public CHandle<inkanimDefinition> Rotation_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(6)] 
		[RED("size_anim")] 
		public CHandle<inkanimDefinition> Size_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(7)] 
		[RED("color_anim")] 
		public CHandle<inkanimDefinition> Color_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(8)] 
		[RED("alpha_anim")] 
		public CHandle<inkanimDefinition> Alpha_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(9)] 
		[RED("position_anim")] 
		public CHandle<inkanimDefinition> Position_anim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(10)] 
		[RED("imageWidget")] 
		public CWeakHandle<inkWidget> ImageWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(12)] 
		[RED("CanRotate")] 
		public CBool CanRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("CanResize")] 
		public CBool CanResize
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("CanChangeColor")] 
		public CBool CanChangeColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("CanChangeAlpha")] 
		public CBool CanChangeAlpha
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("CanMove")] 
		public CBool CanMove
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("defaultSize")] 
		public Vector2 DefaultSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(18)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(19)] 
		[RED("defaultRotation")] 
		public CFloat DefaultRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(21)] 
		[RED("defaultAlpha")] 
		public CFloat DefaultAlpha
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("isHighlighted")] 
		public CBool IsHighlighted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("currentTarget")] 
		public CWeakHandle<inkWidget> CurrentTarget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("currentAnimProxy")] 
		public CHandle<inkanimProxy> CurrentAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public sampleUICustomizableAnimationsController()
		{
			DefaultSize = new Vector2();
			DefaultMargin = new inkMargin();
			DefaultColor = new HDRColor();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
