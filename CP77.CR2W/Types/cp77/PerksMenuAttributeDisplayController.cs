using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeDisplayController : BaseButtonView
	{
		[Ordinal(2)] [RED("widgetWrapper")] public inkWidgetReference WidgetWrapper { get; set; }
		[Ordinal(3)] [RED("foregroundWrapper")] public inkWidgetReference ForegroundWrapper { get; set; }
		[Ordinal(4)] [RED("johnnyWrapper")] public inkWidgetReference JohnnyWrapper { get; set; }
		[Ordinal(5)] [RED("attributeName")] public inkTextWidgetReference AttributeName { get; set; }
		[Ordinal(6)] [RED("attributeIcon")] public inkImageWidgetReference AttributeIcon { get; set; }
		[Ordinal(7)] [RED("attributeLevel")] public inkTextWidgetReference AttributeLevel { get; set; }
		[Ordinal(8)] [RED("frameHovered")] public inkWidgetReference FrameHovered { get; set; }
		[Ordinal(9)] [RED("accent1Hovered")] public inkWidgetReference Accent1Hovered { get; set; }
		[Ordinal(10)] [RED("accent1BGHovered")] public inkWidgetReference Accent1BGHovered { get; set; }
		[Ordinal(11)] [RED("accent2Hovered")] public inkWidgetReference Accent2Hovered { get; set; }
		[Ordinal(12)] [RED("accent2BGHovered")] public inkWidgetReference Accent2BGHovered { get; set; }
		[Ordinal(13)] [RED("topConnectionContainer")] public inkWidgetReference TopConnectionContainer { get; set; }
		[Ordinal(14)] [RED("bottomConnectionContainer")] public inkWidgetReference BottomConnectionContainer { get; set; }
		[Ordinal(15)] [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(16)] [RED("attribute")] public CEnum<PerkMenuAttribute> Attribute { get; set; }
		[Ordinal(17)] [RED("attributeData")] public CHandle<AttributeData> AttributeData { get; set; }

		public PerksMenuAttributeDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
