using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameDebugCheatsSharedState : gameIGameSystemReplicatedState
	{
		[Ordinal(0)]  [RED("activeCheats")] public CArray<gamecheatsystemObjCheats> ActiveCheats { get; set; }
		[Ordinal(1)]  [RED("debugTimeDilationIndex")] public CUInt32 DebugTimeDilationIndex { get; set; }
		[Ordinal(2)]  [RED("debugTimeDilationPlayerIndex")] public CUInt32 DebugTimeDilationPlayerIndex { get; set; }

		public gameDebugCheatsSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
