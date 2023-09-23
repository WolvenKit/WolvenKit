using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocMetersBase : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("barAnchor")] 
		public inkWidgetReference BarAnchor
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("hoverArea")] 
		public inkWidgetReference HoverArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("barWidgetLibraryName")] 
		public CName BarWidgetLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("barGapSize")] 
		public CFloat BarGapSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("slopeLengthModifier")] 
		public CFloat SlopeLengthModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("barIntroAnimDuration")] 
		public CFloat BarIntroAnimDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("barsHeigh")] 
		public CFloat BarsHeigh
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("barsMargin")] 
		public CFloat BarsMargin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("BAR_COUNT")] 
		public CInt32 BAR_COUNT
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("BAR_SLOPE_COUNT")] 
		public CInt32 BAR_SLOPE_COUNT
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("BAR_ANIM_DURATION")] 
		public CFloat BAR_ANIM_DURATION
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("BAR_DELAY_OFFSET")] 
		public CFloat BAR_DELAY_OFFSET
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("pulseAnimtopOpacity")] 
		public CFloat PulseAnimtopOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("pulseAnimbottomOpacity")] 
		public CFloat PulseAnimbottomOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("pulseAnimpulseRate")] 
		public CFloat PulseAnimpulseRate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("pulseAnimdelay")] 
		public CFloat PulseAnimdelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("pulseAnimationParams")] 
		public PulseAnimationParams PulseAnimationParams
		{
			get => GetPropertyValue<PulseAnimationParams>();
			set => SetPropertyValue<PulseAnimationParams>(value);
		}

		[Ordinal(18)] 
		[RED("bars")] 
		public CArray<CWeakHandle<RipperdocNewMeterBar>> Bars
		{
			get => GetPropertyValue<CArray<CWeakHandle<RipperdocNewMeterBar>>>();
			set => SetPropertyValue<CArray<CWeakHandle<RipperdocNewMeterBar>>>(value);
		}

		[Ordinal(19)] 
		[RED("barGaps")] 
		public CArray<CInt32> BarGaps
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(20)] 
		[RED("tooltipData")] 
		public CHandle<RipperdocBarTooltipTooltipData> TooltipData
		{
			get => GetPropertyValue<CHandle<RipperdocBarTooltipTooltipData>>();
			set => SetPropertyValue<CHandle<RipperdocBarTooltipTooltipData>>(value);
		}

		[Ordinal(21)] 
		[RED("barIntroAnimDef")] 
		public CHandle<inkanimDefinition> BarIntroAnimDef
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(22)] 
		[RED("barIntroAnimProxy")] 
		public CHandle<inkanimProxy> BarIntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("isIntroPlayed")] 
		public CBool IsIntroPlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocMetersBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
