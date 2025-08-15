using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotomodeLightIndicatorController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("indicatorRef")] 
		public inkWidgetReference IndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("indicatorIconRef")] 
		public inkWidgetReference IndicatorIconRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("indicatorNumRef")] 
		public inkTextWidgetReference IndicatorNumRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("correctionAngle")] 
		public CFloat CorrectionAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("currentCamera")] 
		public CWeakHandle<entEntity> CurrentCamera
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(7)] 
		[RED("maxSize")] 
		public Vector2 MaxSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public gameuiPhotomodeLightIndicatorController()
		{
			IndicatorRef = new inkWidgetReference();
			IndicatorIconRef = new inkWidgetReference();
			IndicatorNumRef = new inkTextWidgetReference();
			MaxSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
