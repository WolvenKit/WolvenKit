using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUITextSystemController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _locKeyTextWidget;
		private inkTextWidgetReference _localizedTextWidget;
		private CHandle<textTextParameterSet> _textParams;
		private inkTextWidgetReference _numberTextWidget;
		private inkWidgetReference _numberIncreaseButton;
		private inkWidgetReference _numberDecreaseButton;
		private CInt32 _numberToInject;
		private inkTextInputWidgetReference _stringTextInputWidget;
		private CString _stringToInject;
		private inkWidgetReference _timeRefreshButton;
		private CArray<inkWidgetReference> _measurementWidgets;
		private inkWidgetReference _metricSystemButton;
		private inkWidgetReference _imperialSystemButton;
		private inkWidgetReference _animateTextOffsetButton;
		private inkTextWidgetReference _textOffsetWidget;
		private inkWidgetReference _animateTextReplaceButton;
		private inkTextWidgetReference _textReplaceWidget;
		private inkWidgetReference _animateValueButton;
		private inkTextWidgetReference _animateValueWidget;

		[Ordinal(2)] 
		[RED("locKeyTextWidget")] 
		public inkTextWidgetReference LocKeyTextWidget
		{
			get => GetProperty(ref _locKeyTextWidget);
			set => SetProperty(ref _locKeyTextWidget, value);
		}

		[Ordinal(3)] 
		[RED("localizedTextWidget")] 
		public inkTextWidgetReference LocalizedTextWidget
		{
			get => GetProperty(ref _localizedTextWidget);
			set => SetProperty(ref _localizedTextWidget, value);
		}

		[Ordinal(4)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetProperty(ref _textParams);
			set => SetProperty(ref _textParams, value);
		}

		[Ordinal(5)] 
		[RED("numberTextWidget")] 
		public inkTextWidgetReference NumberTextWidget
		{
			get => GetProperty(ref _numberTextWidget);
			set => SetProperty(ref _numberTextWidget, value);
		}

		[Ordinal(6)] 
		[RED("numberIncreaseButton")] 
		public inkWidgetReference NumberIncreaseButton
		{
			get => GetProperty(ref _numberIncreaseButton);
			set => SetProperty(ref _numberIncreaseButton, value);
		}

		[Ordinal(7)] 
		[RED("numberDecreaseButton")] 
		public inkWidgetReference NumberDecreaseButton
		{
			get => GetProperty(ref _numberDecreaseButton);
			set => SetProperty(ref _numberDecreaseButton, value);
		}

		[Ordinal(8)] 
		[RED("numberToInject")] 
		public CInt32 NumberToInject
		{
			get => GetProperty(ref _numberToInject);
			set => SetProperty(ref _numberToInject, value);
		}

		[Ordinal(9)] 
		[RED("stringTextInputWidget")] 
		public inkTextInputWidgetReference StringTextInputWidget
		{
			get => GetProperty(ref _stringTextInputWidget);
			set => SetProperty(ref _stringTextInputWidget, value);
		}

		[Ordinal(10)] 
		[RED("stringToInject")] 
		public CString StringToInject
		{
			get => GetProperty(ref _stringToInject);
			set => SetProperty(ref _stringToInject, value);
		}

		[Ordinal(11)] 
		[RED("timeRefreshButton")] 
		public inkWidgetReference TimeRefreshButton
		{
			get => GetProperty(ref _timeRefreshButton);
			set => SetProperty(ref _timeRefreshButton, value);
		}

		[Ordinal(12)] 
		[RED("measurementWidgets")] 
		public CArray<inkWidgetReference> MeasurementWidgets
		{
			get => GetProperty(ref _measurementWidgets);
			set => SetProperty(ref _measurementWidgets, value);
		}

		[Ordinal(13)] 
		[RED("metricSystemButton")] 
		public inkWidgetReference MetricSystemButton
		{
			get => GetProperty(ref _metricSystemButton);
			set => SetProperty(ref _metricSystemButton, value);
		}

		[Ordinal(14)] 
		[RED("imperialSystemButton")] 
		public inkWidgetReference ImperialSystemButton
		{
			get => GetProperty(ref _imperialSystemButton);
			set => SetProperty(ref _imperialSystemButton, value);
		}

		[Ordinal(15)] 
		[RED("animateTextOffsetButton")] 
		public inkWidgetReference AnimateTextOffsetButton
		{
			get => GetProperty(ref _animateTextOffsetButton);
			set => SetProperty(ref _animateTextOffsetButton, value);
		}

		[Ordinal(16)] 
		[RED("textOffsetWidget")] 
		public inkTextWidgetReference TextOffsetWidget
		{
			get => GetProperty(ref _textOffsetWidget);
			set => SetProperty(ref _textOffsetWidget, value);
		}

		[Ordinal(17)] 
		[RED("animateTextReplaceButton")] 
		public inkWidgetReference AnimateTextReplaceButton
		{
			get => GetProperty(ref _animateTextReplaceButton);
			set => SetProperty(ref _animateTextReplaceButton, value);
		}

		[Ordinal(18)] 
		[RED("textReplaceWidget")] 
		public inkTextWidgetReference TextReplaceWidget
		{
			get => GetProperty(ref _textReplaceWidget);
			set => SetProperty(ref _textReplaceWidget, value);
		}

		[Ordinal(19)] 
		[RED("animateValueButton")] 
		public inkWidgetReference AnimateValueButton
		{
			get => GetProperty(ref _animateValueButton);
			set => SetProperty(ref _animateValueButton, value);
		}

		[Ordinal(20)] 
		[RED("animateValueWidget")] 
		public inkTextWidgetReference AnimateValueWidget
		{
			get => GetProperty(ref _animateValueWidget);
			set => SetProperty(ref _animateValueWidget, value);
		}

		public SampleUITextSystemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
