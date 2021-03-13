using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BroadcastEvent : redEvent
	{
		[Ordinal(0)] [RED("broadcastType")] public CEnum<EBroadcasteingType> BroadcastType { get; set; }
		[Ordinal(1)] [RED("shouldOverride")] public CBool ShouldOverride { get; set; }
		[Ordinal(2)] [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(3)] [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }
		[Ordinal(4)] [RED("stimData")] public stimInvestigateData StimData { get; set; }
		[Ordinal(5)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(6)] [RED("propagationChange")] public CBool PropagationChange { get; set; }
		[Ordinal(7)] [RED("directTarget")] public wCHandle<entEntity> DirectTarget { get; set; }
		[Ordinal(8)] [RED("delay")] public CFloat Delay { get; set; }

		public BroadcastEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
