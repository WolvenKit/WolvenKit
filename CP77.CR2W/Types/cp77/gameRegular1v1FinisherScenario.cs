using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameRegular1v1FinisherScenario : gameIFinisherScenario
	{
		[Ordinal(0)] [RED("attackerWorkspot")] public raRef<workWorkspotResource> AttackerWorkspot { get; set; }
		[Ordinal(1)] [RED("targetWorkspot")] public raRef<workWorkspotResource> TargetWorkspot { get; set; }
		[Ordinal(2)] [RED("syncAnimSlotName")] public CName SyncAnimSlotName { get; set; }
		[Ordinal(3)] [RED("targetPlaybackDelay")] public CFloat TargetPlaybackDelay { get; set; }
		[Ordinal(4)] [RED("targetBlendTime")] public CFloat TargetBlendTime { get; set; }
		[Ordinal(5)] [RED("attackerPlaybackDelay")] public CFloat AttackerPlaybackDelay { get; set; }
		[Ordinal(6)] [RED("attackerBlendTime")] public CFloat AttackerBlendTime { get; set; }
		[Ordinal(7)] [RED("pivotSettings")] public CEnum<gameRegular1v1FinisherScenarioPivotSetting> PivotSettings { get; set; }
		[Ordinal(8)] [RED("attackerIsMaster")] public CBool AttackerIsMaster { get; set; }

		public gameRegular1v1FinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
