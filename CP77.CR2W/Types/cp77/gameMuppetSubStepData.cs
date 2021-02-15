using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetSubStepData : CVariable
	{
		[Ordinal(0)] [RED("frameId")] public CUInt32 FrameId { get; set; }
		[Ordinal(1)] [RED("parentFrameId")] public CUInt32 ParentFrameId { get; set; }
		[Ordinal(2)] [RED("parentFramePrimaryColor")] public CBool ParentFramePrimaryColor { get; set; }
		[Ordinal(3)] [RED("inputState")] public gameMuppetInputState InputState { get; set; }
		[Ordinal(4)] [RED("state")] public gameMuppetState State { get; set; }
		[Ordinal(5)] [RED("resimulationSubsteps")] public CArray<gameMuppetSubStepData> ResimulationSubsteps { get; set; }

		public gameMuppetSubStepData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
