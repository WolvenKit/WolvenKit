using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocNewMeterBar : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("overchargeHighlight")] 
		public inkWidgetReference OverchargeHighlight
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("sizeAnimation")] 
		public CHandle<inkanimProxy> SizeAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(5)] 
		[RED("meterWidth")] 
		public CFloat MeterWidth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetPropertyValue<CHandle<PulseAnimation>>();
			set => SetPropertyValue<CHandle<PulseAnimation>>(value);
		}

		public RipperdocNewMeterBar()
		{
			Bar = new inkWidgetReference();
			OverchargeHighlight = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
