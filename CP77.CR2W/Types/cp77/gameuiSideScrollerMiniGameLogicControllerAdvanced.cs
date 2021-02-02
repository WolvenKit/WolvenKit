using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameLogicControllerAdvanced : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("baseSpeed")] public CFloat BaseSpeed { get; set; }
		[Ordinal(1)]  [RED("playerColliderPositionOffset")] public Vector2 PlayerColliderPositionOffset { get; set; }
		[Ordinal(2)]  [RED("playerColliderSizeOffset")] public Vector2 PlayerColliderSizeOffset { get; set; }
		[Ordinal(3)]  [RED("gameplayRoot")] public inkCompoundWidgetReference GameplayRoot { get; set; }
		[Ordinal(4)]  [RED("playerLibraryName")] public CName PlayerLibraryName { get; set; }
		[Ordinal(5)]  [RED("layers")] public CArray<inkWidgetReference> Layers { get; set; }
		[Ordinal(6)]  [RED("cheatCodes")] public CArray<gameuiSideScrollerCheatCode> CheatCodes { get; set; }
		[Ordinal(7)]  [RED("acceptableCheatKeys")] public CArray<CName> AcceptableCheatKeys { get; set; }

		public gameuiSideScrollerMiniGameLogicControllerAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
