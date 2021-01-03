using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltipData : MessageTooltipData
	{
		[Ordinal(0)]  [RED("attribiuteLevel")] public CString AttribiuteLevel { get; set; }
		[Ordinal(1)]  [RED("maxedOrMinimumLabelText")] public CString MaxedOrMinimumLabelText { get; set; }

		public CharacterCreationTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
