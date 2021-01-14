using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextWidget : inkLeafWidget
	{
		[Ordinal(0)]  [RED("contentHAlign")] public CEnum<inkEHorizontalAlign> ContentHAlign { get; set; }
		[Ordinal(1)]  [RED("contentVAlign")] public CEnum<inkEVerticalAlign> ContentVAlign { get; set; }
		[Ordinal(2)]  [RED("font")] public CHandle<rendFont> Font { get; set; }
		[Ordinal(3)]  [RED("fontFamily")] public raRef<inkFontFamilyResource> FontFamily { get; set; }
		[Ordinal(4)]  [RED("fontSize")] public CUInt32 FontSize { get; set; }
		[Ordinal(5)]  [RED("fontStyle")] public CName FontStyle { get; set; }
		[Ordinal(6)]  [RED("justification")] public CEnum<textJustificationType> Justification { get; set; }
		[Ordinal(7)]  [RED("letterCase")] public CEnum<textLetterCase> LetterCase { get; set; }
		[Ordinal(8)]  [RED("lineHeightPercentage")] public CFloat LineHeightPercentage { get; set; }
		[Ordinal(9)]  [RED("localizationString")] public LocalizationString LocalizationString { get; set; }
		[Ordinal(10)]  [RED("lockFontInGame")] public CBool LockFontInGame { get; set; }
		[Ordinal(11)]  [RED("scrollDelay")] public CUInt16 ScrollDelay { get; set; }
		[Ordinal(12)]  [RED("scrollTextSpeed")] public CFloat ScrollTextSpeed { get; set; }
		[Ordinal(13)]  [RED("text")] public CString Text { get; set; }
		[Ordinal(14)]  [RED("textHorizontalAlignment")] public CEnum<textHorizontalAlignment> TextHorizontalAlignment { get; set; }
		[Ordinal(15)]  [RED("textIdKey")] public CName TextIdKey { get; set; }
		[Ordinal(16)]  [RED("textOverflowPolicy")] public CEnum<textOverflowPolicy> TextOverflowPolicy { get; set; }
		[Ordinal(17)]  [RED("textVerticalAlignment")] public CEnum<textVerticalAlignment> TextVerticalAlignment { get; set; }
		[Ordinal(18)]  [RED("tracking")] public CUInt32 Tracking { get; set; }
		[Ordinal(19)]  [RED("wrappingInfo")] public textWrappingInfo WrappingInfo { get; set; }

		public inkTextWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
