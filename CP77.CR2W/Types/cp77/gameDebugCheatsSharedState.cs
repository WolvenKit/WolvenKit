using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDebugCheatsSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)] [RED("activeCheats")] public CArray<gamecheatsystemObjCheats> ActiveCheats { get; set; }
		[Ordinal(1)] [RED("debugTimeDilationIndex")] public CUInt32 DebugTimeDilationIndex { get; set; }
		[Ordinal(2)] [RED("debugTimeDilationPlayerIndex")] public CUInt32 DebugTimeDilationPlayerIndex { get; set; }

		public gameDebugCheatsSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
