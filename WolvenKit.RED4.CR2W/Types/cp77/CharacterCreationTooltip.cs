using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltip : MessageTooltip
	{
		[Ordinal(5)] [RED("attribiuteLevel")] public inkTextWidgetReference AttribiuteLevel { get; set; }
		[Ordinal(6)] [RED("maxedOrMinimumLabelText")] public inkTextWidgetReference MaxedOrMinimumLabelText { get; set; }
		[Ordinal(7)] [RED("maxedOrMinimumLabel")] public inkWidgetReference MaxedOrMinimumLabel { get; set; }
		[Ordinal(8)] [RED("attribiuteLevelLabel")] public inkWidgetReference AttribiuteLevelLabel { get; set; }

		public CharacterCreationTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
