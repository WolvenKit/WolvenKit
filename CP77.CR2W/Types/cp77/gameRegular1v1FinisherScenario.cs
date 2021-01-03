using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameRegular1v1FinisherScenario : gameIFinisherScenario
	{
		[Ordinal(0)]  [RED("attackerBlendTime")] public CFloat AttackerBlendTime { get; set; }
		[Ordinal(1)]  [RED("attackerIsMaster")] public CBool AttackerIsMaster { get; set; }
		[Ordinal(2)]  [RED("attackerPlaybackDelay")] public CFloat AttackerPlaybackDelay { get; set; }
		[Ordinal(3)]  [RED("attackerWorkspot")] public raRef<workWorkspotResource> AttackerWorkspot { get; set; }
		[Ordinal(4)]  [RED("pivotSettings")] public CEnum<gameRegular1v1FinisherScenarioPivotSetting> PivotSettings { get; set; }
		[Ordinal(5)]  [RED("syncAnimSlotName")] public CName SyncAnimSlotName { get; set; }
		[Ordinal(6)]  [RED("targetBlendTime")] public CFloat TargetBlendTime { get; set; }
		[Ordinal(7)]  [RED("targetPlaybackDelay")] public CFloat TargetPlaybackDelay { get; set; }
		[Ordinal(8)]  [RED("targetWorkspot")] public raRef<workWorkspotResource> TargetWorkspot { get; set; }

		public gameRegular1v1FinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
