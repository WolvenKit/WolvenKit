using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextWidget : inkLeafWidget
	{
		[Ordinal(20)] [RED("localizationString")] public LocalizationString LocalizationString { get; set; }
		[Ordinal(21)] [RED("textIdKey")] public CName TextIdKey { get; set; }
		[Ordinal(22)] [RED("text")] public CString Text { get; set; }
		[Ordinal(23)] [RED("fontFamily")] public raRef<inkFontFamilyResource> FontFamily { get; set; }
		[Ordinal(24)] [RED("fontStyle")] public CName FontStyle { get; set; }
		[Ordinal(25)] [RED("fontSize")] public CUInt32 FontSize { get; set; }
		[Ordinal(26)] [RED("font")] public CHandle<rendFont> Font { get; set; }
		[Ordinal(27)] [RED("letterCase")] public CEnum<textLetterCase> LetterCase { get; set; }
		[Ordinal(28)] [RED("tracking")] public CUInt32 Tracking { get; set; }
		[Ordinal(29)] [RED("lockFontInGame")] public CBool LockFontInGame { get; set; }
		[Ordinal(30)] [RED("wrappingInfo")] public textWrappingInfo WrappingInfo { get; set; }
		[Ordinal(31)] [RED("lineHeightPercentage")] public CFloat LineHeightPercentage { get; set; }
		[Ordinal(32)] [RED("justification")] public CEnum<textJustificationType> Justification { get; set; }
		[Ordinal(33)] [RED("textHorizontalAlignment")] public CEnum<textHorizontalAlignment> TextHorizontalAlignment { get; set; }
		[Ordinal(34)] [RED("textVerticalAlignment")] public CEnum<textVerticalAlignment> TextVerticalAlignment { get; set; }
		[Ordinal(35)] [RED("textOverflowPolicy")] public CEnum<textOverflowPolicy> TextOverflowPolicy { get; set; }
		[Ordinal(36)] [RED("scrollTextSpeed")] public CFloat ScrollTextSpeed { get; set; }
		[Ordinal(37)] [RED("scrollDelay")] public CUInt16 ScrollDelay { get; set; }
		[Ordinal(38)] [RED("contentHAlign")] public CEnum<inkEHorizontalAlign> ContentHAlign { get; set; }
		[Ordinal(39)] [RED("contentVAlign")] public CEnum<inkEVerticalAlign> ContentVAlign { get; set; }

		public inkTextWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
