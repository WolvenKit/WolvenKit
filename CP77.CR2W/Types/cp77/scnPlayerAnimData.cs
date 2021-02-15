using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlayerAnimData : CVariable
	{
		[Ordinal(0)] [RED("tierData")] public CHandle<gameSceneTierData> TierData { get; set; }
		[Ordinal(1)] [RED("useZSnapping")] public CBool UseZSnapping { get; set; }
		[Ordinal(2)] [RED("unmountBodyCarry")] public CBool UnmountBodyCarry { get; set; }

		public scnPlayerAnimData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
