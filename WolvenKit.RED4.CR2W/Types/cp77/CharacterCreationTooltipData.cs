using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltipData : MessageTooltipData
	{
		[Ordinal(4)] [RED("attribiuteLevel")] public CString AttribiuteLevel { get; set; }
		[Ordinal(5)] [RED("maxedOrMinimumLabelText")] public CString MaxedOrMinimumLabelText { get; set; }

		public CharacterCreationTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
