using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorResaveData : CVariable
	{
		[Ordinal(0)] [RED("doorType")] public CEnum<EDoorType> DoorType { get; set; }
		[Ordinal(1)] [RED("canPlayerToggleLockState")] public CBool CanPlayerToggleLockState { get; set; }
		[Ordinal(2)] [RED("canPlayerToggleSealState")] public CBool CanPlayerToggleSealState { get; set; }
		[Ordinal(3)] [RED("initialStatus")] public CEnum<EDoorStatus> InitialStatus { get; set; }
		[Ordinal(4)] [RED("keycardName")] public TweakDBID KeycardName { get; set; }
		[Ordinal(5)] [RED("passcode")] public CName Passcode { get; set; }

		public DoorResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
