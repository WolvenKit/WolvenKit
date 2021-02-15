using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputState : CVariable
	{
		[Ordinal(0)] [RED("frameId")] public CUInt32 FrameId { get; set; }

		public gameMuppetInputState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
