using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageDescTooltip : MessageTooltip
	{
		[Ordinal(5)] [RED("titleWrapper")] public inkWidgetReference TitleWrapper { get; set; }
		[Ordinal(6)] [RED("descriptionWrapper")] public inkWidgetReference DescriptionWrapper { get; set; }
		[Ordinal(7)] [RED("descriptionLine")] public inkWidgetReference DescriptionLine { get; set; }

		public MessageDescTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
