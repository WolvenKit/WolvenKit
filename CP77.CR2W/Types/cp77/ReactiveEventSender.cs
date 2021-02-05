using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ReactiveEventSender : AISignalSenderTask
	{
		[Ordinal(0)]  [RED("tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(1)]  [RED("flags")] public CArray<CEnum<EAIGateSignalFlags>> Flags { get; set; }
		[Ordinal(2)]  [RED("priority")] public CFloat Priority { get; set; }
		[Ordinal(3)]  [RED("signalId")] public CUInt32 SignalId { get; set; }
		[Ordinal(4)]  [RED("behaviorArgumentNameTag")] public CName BehaviorArgumentNameTag { get; set; }
		[Ordinal(5)]  [RED("behaviorArgumentFloatPriority")] public CName BehaviorArgumentFloatPriority { get; set; }
		[Ordinal(6)]  [RED("behaviorArgumentNameFlag")] public CName BehaviorArgumentNameFlag { get; set; }
		[Ordinal(7)]  [RED("reactiveType")] public CName ReactiveType { get; set; }

		public ReactiveEventSender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
