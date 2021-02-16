using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDJob : CVariable
	{
		[Ordinal(0)] [RED("actor")] public wCHandle<gameHudActor> Actor { get; set; }
		[Ordinal(1)] [RED("instruction")] public CHandle<HUDInstruction> Instruction { get; set; }

		public HUDJob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
