using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUITextSystemController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("locKeyTextWidget")] public inkTextWidgetReference LocKeyTextWidget { get; set; }
		[Ordinal(3)] [RED("localizedTextWidget")] public inkTextWidgetReference LocalizedTextWidget { get; set; }
		[Ordinal(4)] [RED("textParams")] public CHandle<textTextParameterSet> TextParams { get; set; }
		[Ordinal(5)] [RED("numberTextWidget")] public inkTextWidgetReference NumberTextWidget { get; set; }
		[Ordinal(6)] [RED("numberIncreaseButton")] public inkWidgetReference NumberIncreaseButton { get; set; }
		[Ordinal(7)] [RED("numberDecreaseButton")] public inkWidgetReference NumberDecreaseButton { get; set; }
		[Ordinal(8)] [RED("numberToInject")] public CInt32 NumberToInject { get; set; }
		[Ordinal(9)] [RED("stringTextInputWidget")] public inkTextInputWidgetReference StringTextInputWidget { get; set; }
		[Ordinal(10)] [RED("stringToInject")] public CString StringToInject { get; set; }
		[Ordinal(11)] [RED("timeRefreshButton")] public inkWidgetReference TimeRefreshButton { get; set; }
		[Ordinal(12)] [RED("measurementWidgets")] public CArray<inkWidgetReference> MeasurementWidgets { get; set; }
		[Ordinal(13)] [RED("metricSystemButton")] public inkWidgetReference MetricSystemButton { get; set; }
		[Ordinal(14)] [RED("imperialSystemButton")] public inkWidgetReference ImperialSystemButton { get; set; }
		[Ordinal(15)] [RED("animateTextOffsetButton")] public inkWidgetReference AnimateTextOffsetButton { get; set; }
		[Ordinal(16)] [RED("textOffsetWidget")] public inkTextWidgetReference TextOffsetWidget { get; set; }
		[Ordinal(17)] [RED("animateTextReplaceButton")] public inkWidgetReference AnimateTextReplaceButton { get; set; }
		[Ordinal(18)] [RED("textReplaceWidget")] public inkTextWidgetReference TextReplaceWidget { get; set; }
		[Ordinal(19)] [RED("animateValueButton")] public inkWidgetReference AnimateValueButton { get; set; }
		[Ordinal(20)] [RED("animateValueWidget")] public inkTextWidgetReference AnimateValueWidget { get; set; }

		public SampleUITextSystemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
