using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LiftSetup : CVariable
	{
		[Ordinal(0)]  [RED("startingFloorTerminal")] public CInt32 StartingFloorTerminal { get; set; }
		[Ordinal(1)]  [RED("liftSpeed")] public CFloat LiftSpeed { get; set; }
		[Ordinal(2)]  [RED("liftStartingDelay")] public CFloat LiftStartingDelay { get; set; }
		[Ordinal(3)]  [RED("liftTravelTimeOverride")] public CFloat LiftTravelTimeOverride { get; set; }
		[Ordinal(4)]  [RED("isLiftTravelTimeOverride")] public CBool IsLiftTravelTimeOverride { get; set; }
		[Ordinal(5)]  [RED("emptyLiftSpeedMultiplier")] public CFloat EmptyLiftSpeedMultiplier { get; set; }
		[Ordinal(6)]  [RED("radioStationNumer")] public CInt32 RadioStationNumer { get; set; }
		[Ordinal(7)]  [RED("speakerDestroyedQuestFact")] public CName SpeakerDestroyedQuestFact { get; set; }
		[Ordinal(8)]  [RED("speakerDestroyedVFX")] public CName SpeakerDestroyedVFX { get; set; }
		[Ordinal(9)]  [RED("authorizationTextOverride")] public CString AuthorizationTextOverride { get; set; }

		public LiftSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
