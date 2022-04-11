using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleUITextSystemController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("locKeyTextWidget")] 
		public inkTextWidgetReference LocKeyTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("localizedTextWidget")] 
		public inkTextWidgetReference LocalizedTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(5)] 
		[RED("numberTextWidget")] 
		public inkTextWidgetReference NumberTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("numberIncreaseButton")] 
		public inkWidgetReference NumberIncreaseButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("numberDecreaseButton")] 
		public inkWidgetReference NumberDecreaseButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("numberToInject")] 
		public CInt32 NumberToInject
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("stringTextInputWidget")] 
		public inkTextInputWidgetReference StringTextInputWidget
		{
			get => GetPropertyValue<inkTextInputWidgetReference>();
			set => SetPropertyValue<inkTextInputWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("stringToInject")] 
		public CString StringToInject
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("timeRefreshButton")] 
		public inkWidgetReference TimeRefreshButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("measurementWidgets")] 
		public CArray<inkWidgetReference> MeasurementWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(13)] 
		[RED("metricSystemButton")] 
		public inkWidgetReference MetricSystemButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("imperialSystemButton")] 
		public inkWidgetReference ImperialSystemButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("animateTextOffsetButton")] 
		public inkWidgetReference AnimateTextOffsetButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("textOffsetWidget")] 
		public inkTextWidgetReference TextOffsetWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("animateTextReplaceButton")] 
		public inkWidgetReference AnimateTextReplaceButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("textReplaceWidget")] 
		public inkTextWidgetReference TextReplaceWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("animateValueButton")] 
		public inkWidgetReference AnimateValueButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("animateValueWidget")] 
		public inkTextWidgetReference AnimateValueWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public SampleUITextSystemController()
		{
			LocKeyTextWidget = new();
			LocalizedTextWidget = new();
			NumberTextWidget = new();
			NumberIncreaseButton = new();
			NumberDecreaseButton = new();
			NumberToInject = 1;
			StringTextInputWidget = new();
			StringToInject = "Dex";
			TimeRefreshButton = new();
			MeasurementWidgets = new();
			MetricSystemButton = new();
			ImperialSystemButton = new();
			AnimateTextOffsetButton = new();
			TextOffsetWidget = new();
			AnimateTextReplaceButton = new();
			TextReplaceWidget = new();
			AnimateValueButton = new();
			AnimateValueWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
