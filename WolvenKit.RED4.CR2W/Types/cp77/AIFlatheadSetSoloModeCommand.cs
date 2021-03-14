using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFlatheadSetSoloModeCommand : AIFollowerCommand
	{
		[Ordinal(5)] [RED("soloModeState")] public CBool SoloModeState { get; set; }

		public AIFlatheadSetSoloModeCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
