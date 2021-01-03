using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIReactionData : IScriptable
	{
		[Ordinal(0)]  [RED("escalateProvoke")] public CBool EscalateProvoke { get; set; }
		[Ordinal(1)]  [RED("initAnimInWorkspot")] public CBool InitAnimInWorkspot { get; set; }
		[Ordinal(2)]  [RED("reactionBehaviorAIPriority")] public CFloat ReactionBehaviorAIPriority { get; set; }
		[Ordinal(3)]  [RED("reactionBehaviorName")] public CEnum<gamedataOutput> ReactionBehaviorName { get; set; }
		[Ordinal(4)]  [RED("reactionCooldown")] public CFloat ReactionCooldown { get; set; }
		[Ordinal(5)]  [RED("reactionPriority")] public CInt32 ReactionPriority { get; set; }
		[Ordinal(6)]  [RED("recentReactionTimeStamp")] public CFloat RecentReactionTimeStamp { get; set; }
		[Ordinal(7)]  [RED("stimData")] public CHandle<senseStimuliData> StimData { get; set; }
		[Ordinal(8)]  [RED("stimEventData")] public StimEventData StimEventData { get; set; }
		[Ordinal(9)]  [RED("stimInvestigateData")] public stimInvestigateData StimInvestigateData { get; set; }
		[Ordinal(10)]  [RED("stimPriority")] public CEnum<gamedataStimPriority> StimPriority { get; set; }
		[Ordinal(11)]  [RED("stimSource")] public Vector4 StimSource { get; set; }
		[Ordinal(12)]  [RED("stimTarget")] public wCHandle<gameObject> StimTarget { get; set; }
		[Ordinal(13)]  [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }
		[Ordinal(14)]  [RED("validTillTimeStamp")] public CFloat ValidTillTimeStamp { get; set; }

		public AIReactionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
