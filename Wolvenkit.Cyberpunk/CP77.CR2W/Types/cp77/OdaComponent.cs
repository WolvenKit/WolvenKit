using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OdaComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("actionBlackBoard")] public CHandle<gameIBlackboard> ActionBlackBoard { get; set; }
		[Ordinal(1)]  [RED("healthListener")] public CHandle<OdaEmergencyListener> HealthListener { get; set; }
		[Ordinal(2)]  [RED("odaAIComponent")] public CHandle<AIHumanComponent> OdaAIComponent { get; set; }
		[Ordinal(3)]  [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(4)]  [RED("owner_id")] public entEntityID Owner_id { get; set; }
		[Ordinal(5)]  [RED("statPoolSystem")] public CHandle<gameStatPoolsSystem> StatPoolSystem { get; set; }
		[Ordinal(6)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(7)]  [RED("statusEffect_emergency")] public TweakDBID StatusEffect_emergency { get; set; }
		[Ordinal(8)]  [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }

		public OdaComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
