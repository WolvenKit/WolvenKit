using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ToggleNetrunnerDive : ActionBool
	{
		[Ordinal(0)]  [RED("attempt")] public CInt32 Attempt { get; set; }
		[Ordinal(1)]  [RED("isRemote")] public CBool IsRemote { get; set; }
		[Ordinal(2)]  [RED("skipMinigame")] public CBool SkipMinigame { get; set; }

		public ToggleNetrunnerDive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
