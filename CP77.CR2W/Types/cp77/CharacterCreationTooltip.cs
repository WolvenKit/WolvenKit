using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltip : MessageTooltip
	{
		[Ordinal(0)]  [RED("attribiuteLevel")] public inkTextWidgetReference AttribiuteLevel { get; set; }
		[Ordinal(1)]  [RED("attribiuteLevelLabel")] public inkWidgetReference AttribiuteLevelLabel { get; set; }
		[Ordinal(2)]  [RED("maxedOrMinimumLabel")] public inkWidgetReference MaxedOrMinimumLabel { get; set; }
		[Ordinal(3)]  [RED("maxedOrMinimumLabelText")] public inkTextWidgetReference MaxedOrMinimumLabelText { get; set; }

		public CharacterCreationTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
