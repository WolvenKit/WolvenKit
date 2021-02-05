using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltip : MessageTooltip
	{
		[Ordinal(0)]  [RED("Root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(1)]  [RED("Title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(2)]  [RED("Description")] public inkTextWidgetReference Description { get; set; }
		[Ordinal(3)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(4)]  [RED("attribiuteLevel")] public inkTextWidgetReference AttribiuteLevel { get; set; }
		[Ordinal(5)]  [RED("maxedOrMinimumLabelText")] public inkTextWidgetReference MaxedOrMinimumLabelText { get; set; }
		[Ordinal(6)]  [RED("maxedOrMinimumLabel")] public inkWidgetReference MaxedOrMinimumLabel { get; set; }
		[Ordinal(7)]  [RED("attribiuteLevelLabel")] public inkWidgetReference AttribiuteLevelLabel { get; set; }

		public CharacterCreationTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
