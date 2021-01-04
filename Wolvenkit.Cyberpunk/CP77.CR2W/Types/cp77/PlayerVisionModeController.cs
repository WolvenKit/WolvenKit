using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeController : IScriptable
	{
		[Ordinal(0)]  [RED("blackboardIds")] public PlayerVisionModeControllerBBIds BlackboardIds { get; set; }
		[Ordinal(1)]  [RED("blackboardListeners")] public PlayerVisionModeControllerBBListeners BlackboardListeners { get; set; }
		[Ordinal(2)]  [RED("blackboardListenersFunctions")] public PlayerVisionModeControllerBlackboardListenersFunctions BlackboardListenersFunctions { get; set; }
		[Ordinal(3)]  [RED("blackboardValuesIds")] public PlayerVisionModeControllerBBValuesIds BlackboardValuesIds { get; set; }
		[Ordinal(4)]  [RED("gameplayActiveFlags")] public PlayerVisionModeControllerActiveFlags GameplayActiveFlags { get; set; }
		[Ordinal(5)]  [RED("gameplayActiveFlagsRefreshPolicy")] public PlayerVisionModeControllerRefreshPolicy GameplayActiveFlagsRefreshPolicy { get; set; }
		[Ordinal(6)]  [RED("inputActionsNames")] public PlayerVisionModeControllerInputActionsNames InputActionsNames { get; set; }
		[Ordinal(7)]  [RED("inputActiveFlags")] public PlayerVisionModeControllerInputActiveFlags InputActiveFlags { get; set; }
		[Ordinal(8)]  [RED("inputListeners")] public PlayerVisionModeControllerInputListeners InputListeners { get; set; }
		[Ordinal(9)]  [RED("otherVars")] public PlayerVisionModeControllerOtherVars OtherVars { get; set; }
		[Ordinal(10)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public PlayerVisionModeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
