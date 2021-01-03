using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SampleUITextSystemController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("animateTextOffsetButton")] public inkWidgetReference AnimateTextOffsetButton { get; set; }
		[Ordinal(1)]  [RED("animateTextReplaceButton")] public inkWidgetReference AnimateTextReplaceButton { get; set; }
		[Ordinal(2)]  [RED("animateValueButton")] public inkWidgetReference AnimateValueButton { get; set; }
		[Ordinal(3)]  [RED("animateValueWidget")] public inkTextWidgetReference AnimateValueWidget { get; set; }
		[Ordinal(4)]  [RED("imperialSystemButton")] public inkWidgetReference ImperialSystemButton { get; set; }
		[Ordinal(5)]  [RED("locKeyTextWidget")] public inkTextWidgetReference LocKeyTextWidget { get; set; }
		[Ordinal(6)]  [RED("localizedTextWidget")] public inkTextWidgetReference LocalizedTextWidget { get; set; }
		[Ordinal(7)]  [RED("measurementWidgets")] public CArray<inkWidgetReference> MeasurementWidgets { get; set; }
		[Ordinal(8)]  [RED("metricSystemButton")] public inkWidgetReference MetricSystemButton { get; set; }
		[Ordinal(9)]  [RED("numberDecreaseButton")] public inkWidgetReference NumberDecreaseButton { get; set; }
		[Ordinal(10)]  [RED("numberIncreaseButton")] public inkWidgetReference NumberIncreaseButton { get; set; }
		[Ordinal(11)]  [RED("numberTextWidget")] public inkTextWidgetReference NumberTextWidget { get; set; }
		[Ordinal(12)]  [RED("numberToInject")] public CInt32 NumberToInject { get; set; }
		[Ordinal(13)]  [RED("stringTextInputWidget")] public inkTextInputWidgetReference StringTextInputWidget { get; set; }
		[Ordinal(14)]  [RED("stringToInject")] public CString StringToInject { get; set; }
		[Ordinal(15)]  [RED("textOffsetWidget")] public inkTextWidgetReference TextOffsetWidget { get; set; }
		[Ordinal(16)]  [RED("textParams")] public CHandle<textTextParameterSet> TextParams { get; set; }
		[Ordinal(17)]  [RED("textReplaceWidget")] public inkTextWidgetReference TextReplaceWidget { get; set; }
		[Ordinal(18)]  [RED("timeRefreshButton")] public inkWidgetReference TimeRefreshButton { get; set; }

		public SampleUITextSystemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
