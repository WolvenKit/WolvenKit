using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessageDescTooltip : MessageTooltip
	{
		[Ordinal(0)]  [RED("descriptionLine")] public inkWidgetReference DescriptionLine { get; set; }
		[Ordinal(1)]  [RED("descriptionWrapper")] public inkWidgetReference DescriptionWrapper { get; set; }
		[Ordinal(2)]  [RED("titleWrapper")] public inkWidgetReference TitleWrapper { get; set; }

		public MessageDescTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
