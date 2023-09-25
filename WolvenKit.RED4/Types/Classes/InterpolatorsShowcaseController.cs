using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InterpolatorsShowcaseController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("interpolationType")] 
		public CEnum<inkanimInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationType>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationType>>(value);
		}

		[Ordinal(2)] 
		[RED("interpolationMode")] 
		public CEnum<inkanimInterpolationMode> InterpolationMode
		{
			get => GetPropertyValue<CEnum<inkanimInterpolationMode>>();
			set => SetPropertyValue<CEnum<inkanimInterpolationMode>>(value);
		}

		[Ordinal(3)] 
		[RED("overlay")] 
		public CWeakHandle<inkWidget> Overlay
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("heightBar")] 
		public CWeakHandle<inkWidget> HeightBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("widthBar")] 
		public CWeakHandle<inkWidget> WidthBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(6)] 
		[RED("graphPointer")] 
		public CWeakHandle<inkWidget> GraphPointer
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("counterText")] 
		public CWeakHandle<inkTextWidget> CounterText
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("sizeWidget")] 
		public CWeakHandle<inkWidget> SizeWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(9)] 
		[RED("rotationWidget")] 
		public CWeakHandle<inkWidget> RotationWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("marginWidget")] 
		public CWeakHandle<inkWidget> MarginWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(11)] 
		[RED("colorWidget")] 
		public CWeakHandle<inkWidget> ColorWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("sizeAnim")] 
		public CHandle<inkanimDefinition> SizeAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(13)] 
		[RED("rotationAnim")] 
		public CHandle<inkanimDefinition> RotationAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(14)] 
		[RED("marginAnim")] 
		public CHandle<inkanimDefinition> MarginAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(15)] 
		[RED("colorAnim")] 
		public CHandle<inkanimDefinition> ColorAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(16)] 
		[RED("followTimelineAnim")] 
		public CHandle<inkanimDefinition> FollowTimelineAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(17)] 
		[RED("interpolateAnim")] 
		public CHandle<inkanimDefinition> InterpolateAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(18)] 
		[RED("startMargin")] 
		public inkMargin StartMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(19)] 
		[RED("animLength")] 
		public CFloat AnimLength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("animConstructor")] 
		public CHandle<AnimationsConstructor> AnimConstructor
		{
			get => GetPropertyValue<CHandle<AnimationsConstructor>>();
			set => SetPropertyValue<CHandle<AnimationsConstructor>>(value);
		}

		public InterpolatorsShowcaseController()
		{
			StartMargin = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
